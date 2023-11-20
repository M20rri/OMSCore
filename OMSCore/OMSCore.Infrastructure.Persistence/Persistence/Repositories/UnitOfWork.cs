using Application.Interfaces;
using Application.Interfaces.Repositories;
using Infrastructure.Persistence.Persistence.Contexts;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IUserMasterRepositoryAsync UserMasterRepositoryAsync => new UserMasterRepositoryAsync(_dbContext);
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
