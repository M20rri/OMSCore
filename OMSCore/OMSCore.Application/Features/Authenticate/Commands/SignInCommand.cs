using MediatR;
using OMSCore.Application.DTOs.Authenticate;
using OMSCore.Application.Exceptions;
using OMSCore.Application.Extensions;
using OMSCore.Application.Interfaces.Repositories;
using OMSCore.Domain.Settings;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace OMSCore.Application.Features.Authenticate.Commands
{
    public record SignInCommand(SignIn model) : IRequest<SingInToken>;

    public sealed class SignInHandler : IRequestHandler<SignInCommand, SingInToken>
    {
        private readonly IUserMasterRepositoryAsync _authenticateRepositoryAsync;
        private readonly JWTSettings _jwtSetting;
        public SignInHandler(IUserMasterRepositoryAsync authenticateRepositoryAsync, JWTSettings jwtSetting)
        {
            _authenticateRepositoryAsync = authenticateRepositoryAsync;
            _jwtSetting = jwtSetting;
        }

        public async Task<SingInToken> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            SignInCommandValidator validationRules = new SignInCommandValidator(_authenticateRepositoryAsync);
            var password = request.model.Password.EncryptPass();
            request.model.Password = password;
            var result = await validationRules.ValidateAsync(request.model);
            if (result.Errors.Any())
            {
                var Errors = result.Errors.Select(x => x.ErrorMessage).ToList();
                throw new ValidationException(Errors, (int)HttpStatusCode.BadRequest);
            }

            var user = await _authenticateRepositoryAsync.GetByUserNameAsync(request.model.Username);
            var tokenDto = await new Token(user.Id.ToString(), user.UserId, "AdminOFS").GenerateTokenAsync(_jwtSetting);
            return tokenDto;
        }
    }
}
