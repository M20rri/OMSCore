using FluentValidation;
using OMSCore.Application.DTOs.Authenticate;
using OMSCore.Application.Interfaces.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace OMSCore.Application.Validators
{
    public class SignInCommandValidator : AbstractValidator<SignIn>
    {
        private readonly IUserMasterRepositoryAsync _userMaster;
        public SignInCommandValidator(IUserMasterRepositoryAsync userMaster)
        {
            _userMaster = userMaster;

            RuleFor(x => x.Username).NotNull().NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password is required");

            When(x => !string.IsNullOrEmpty(x.Username) && !string.IsNullOrEmpty(x.Password), () =>
            {
                RuleFor(o => o).MustAsync(IsValidCreds)
                .WithMessage("Invalid login Credentials");
            });
        }

        private async Task<bool> IsValidCreds(SignIn model, CancellationToken cancellationToken)
        {
            return await _userMaster.IsExistAsync(model);
        }
    }
}
