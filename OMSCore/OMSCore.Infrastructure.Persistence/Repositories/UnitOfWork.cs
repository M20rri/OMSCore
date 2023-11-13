using OMSCore.Application.Interfaces;
using OMSCore.Application.Interfaces.Repositories;
using OMSCore.Domain.Entities;
using OMSCore.Infrastructure.Persistence.Contexts;
using OMSCore.Infrastructure.Persistence.Repository;
using System.Threading.Tasks;

namespace OMSCore.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IUserMasterRepositoryAsync UserMasterRepositoryAsync => new UserMasterRepositoryAsync(_dbContext);
        //public IGenericRepositoryAsync<UserMaster> UserMasterRepositoryAsync => new GenericRepositoryAsync<UserMaster>(_dbContext);
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
