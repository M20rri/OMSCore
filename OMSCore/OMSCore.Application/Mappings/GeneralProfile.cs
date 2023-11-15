using AutoMapper;
using OMSCore.Application.DTOs.UserMaster;
using OMSCore.Domain.Entities;

namespace OMSCore.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            //CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            //CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            //CreateMap<CreatePositionCommand, Position>();
            CreateMap<UserMaster, UserMasterResponse>();
        }
    }
}