using OMSCore.Application.DTOs.Authenticate;
using OMSCore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OMSCore.Application.Interfaces
{
    public interface IUserMasterService
    {
        Task<SingInToken> SignIn(SignIn model);
        Task<bool> IsExistAsync(SignIn model);
        Task<UserMaster> GetByUserNameAsync(string userId);
        Task<List<UserMaster>> GetAll();
    }
}
