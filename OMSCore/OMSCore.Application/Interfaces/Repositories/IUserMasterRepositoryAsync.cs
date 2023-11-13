using OMSCore.Domain.Entities;
using System.Threading.Tasks;
using OMSCore.Application.DTOs.Authenticate;

namespace OMSCore.Application.Interfaces.Repositories
{
    public interface IUserMasterRepositoryAsync : IGenericRepositoryAsync<UserMaster>
    {
        Task<UserMaster> SignInAsync(SignIn model);
        Task<bool> IsExistAsync(SignIn model);
        Task<UserMaster> GetByUserNameAsync(string userId);
    }
}
