using AutoMapper;
using OMSCore.Application.DTOs.Authenticate;
using OMSCore.Application.Exceptions;
using OMSCore.Application.Extensions;
using OMSCore.Application.Interfaces;
using OMSCore.Application.Validators;
using OMSCore.Domain.Entities;
using OMSCore.Domain.Settings;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OMSCore.Infrastructure.Shared.Services
{
    public class UserMasterService : IUserMasterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly JWTSettings _jwtSetting;
        public UserMasterService(IMapper mapper, IUnitOfWork unitOfWork, JWTSettings jwtSetting)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _jwtSetting = jwtSetting;
        }

        public async Task<UserMaster> GetByUserNameAsync(string userId)
        {
            return await _unitOfWork.UserMasterRepositoryAsync.GetByUserNameAsync(userId);
        }

        public async Task<bool> IsExistAsync(SignIn model)
        {
            return await _unitOfWork.UserMasterRepositoryAsync.IsExistAsync(model);
        }

        public async Task<SingInToken> SignIn(SignIn model)
        {
            SignInCommandValidator validationRules = new SignInCommandValidator(_unitOfWork.UserMasterRepositoryAsync);
            var password = model.Password.EncryptPass();
            model.Password = password;
            var result = await validationRules.ValidateAsync(model);
            if (result.Errors.Any())
            {
                var Errors = result.Errors.Select(x => x.ErrorMessage).ToList();
                throw new ValidationException(Errors, (int)HttpStatusCode.BadRequest);
            }

            var user = await _unitOfWork.UserMasterRepositoryAsync.SignInAsync(model);
            return await new Token(user.Id.ToString(), user.UserId, "AdminOFS").GenerateTokenAsync(_jwtSetting);

        }
    }
}
