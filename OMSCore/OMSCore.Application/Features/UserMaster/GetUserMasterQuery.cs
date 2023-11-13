using MediatR;
using OMSCore.Application.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OMSCore.Application.Features.UserMaster
{
    public record GetUserMasterQuery() : IRequest<IEnumerable<Domain.Entities.UserMaster>>;

    public sealed class GetUserMasterHandler : IRequestHandler<GetUserMasterQuery, IEnumerable<Domain.Entities.UserMaster>>
    {
        private readonly IUserMasterRepositoryAsync _userMasterRepositoryAsync;

        public GetUserMasterHandler(IUserMasterRepositoryAsync userMasterRepositoryAsync)
        {
            _userMasterRepositoryAsync = userMasterRepositoryAsync;
        }

        public async Task<IEnumerable<Domain.Entities.UserMaster>> Handle(GetUserMasterQuery request, CancellationToken cancellationToken)
        {
            return await _userMasterRepositoryAsync.GetAllAsync();
        }
    }
}
