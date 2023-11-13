using OMSCore.Application.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace OMSCore.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserMasterRepositoryAsync UserMasterRepositoryAsync { get; }
        Task SaveChangesAsync();
    }
}
