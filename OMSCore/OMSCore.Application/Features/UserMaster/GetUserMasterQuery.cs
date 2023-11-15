using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OMSCore.Application.DTOs.UserMaster;
using OMSCore.Application.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OMSCore.Application.Features.UserMaster
{
    public record GetUserMasterQuery() : IRequest<List<UserMasterResponse>>;

    public sealed class GetUserMasterHandler : IRequestHandler<GetUserMasterQuery, List<UserMasterResponse>>
    {
        private readonly IUserMasterRepositoryAsync _userMasterRepositoryAsync;
        private readonly IMapper _mapper;
        public GetUserMasterHandler(IUserMasterRepositoryAsync userMasterRepositoryAsync, IMapper mapper)
        {
            _userMasterRepositoryAsync = userMasterRepositoryAsync;
            _mapper = mapper;
        }

        public async Task<List<UserMasterResponse>> Handle(GetUserMasterQuery request, CancellationToken cancellationToken)
        {
            var response = await _userMasterRepositoryAsync.GetAllAsync();
            return _mapper.Map<List<UserMasterResponse>>(await response.ToListAsync());
        }
    }
}
