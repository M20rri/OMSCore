using System.Threading.Tasks;
using Application.DTOs.Authenticate;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IUserMasterRepositoryAsync : IGenericRepositoryAsync<UserMaster>
    {
        Task<UserMaster> SignInAsync(SignIn model);
        Task<bool> IsExistAsync(SignIn model);
        Task<UserMaster> GetByUserNameAsync(string userId);
    }
}
