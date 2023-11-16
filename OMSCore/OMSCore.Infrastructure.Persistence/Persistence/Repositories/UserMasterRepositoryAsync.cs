using Microsoft.EntityFrameworkCore;
using OMSCore.Application.DTOs.Authenticate;
using OMSCore.Application.Interfaces.Repositories;
using OMSCore.Domain.Entities;
using OMSCore.Infrastructure.Persistence.Persistence.Contexts;
using System.Threading.Tasks;

namespace OMSCore.Infrastructure.Persistence.Persistence.Repositories
{
    internal class UserMasterRepositoryAsync : GenericRepositoryAsync<UserMaster>, IUserMasterRepositoryAsync
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<UserMaster> _userMaster;
        public UserMasterRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _userMaster = dbContext.Set<UserMaster>();
        }

        public async Task<UserMaster> GetByUserNameAsync(string userId)
        {
            return await _userMaster.FirstOrDefaultAsync(a => a.UserId == userId);
        }

        public async Task<bool> IsExistAsync(SignIn model)
        {
            return await _userMaster
              .AnyAsync(p => p.UserId == model.Username && p.Password == model.Password);
        }

        public async Task<UserMaster> SignInAsync(SignIn model)
        {
            return await _userMaster
              .FirstOrDefaultAsync(p => p.UserId == model.Username && p.Password == model.Password);
        }
    }
}
