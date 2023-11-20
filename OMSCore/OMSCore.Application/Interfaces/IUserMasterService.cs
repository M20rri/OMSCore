using Application.DTOs.Authenticate;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserMasterService
    {
        Task<SingInToken> SignIn(SignIn model);
        Task<bool> IsExistAsync(SignIn model);
        Task<UserMaster> GetByUserNameAsync(string userId);
        Task<List<UserMaster>> GetAll();
    }
}
