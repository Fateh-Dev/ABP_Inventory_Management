using AutoMapper;
using InventoryManagement.Application.Contracts.Enumerations;
using InventoryManagement.Domain.Enumerations;

namespace InventoryManagement.Application.Enumerations
{
    public class InventoryManagementApplicationAutoMapperProfile : Profile
    {
        public InventoryManagementApplicationAutoMapperProfile ()
        {
            CreateMap<Enumeration, EnumerationDto>();
            CreateMap<CreateUpdateEnumerationDto,Enumeration>();
        }
    }
}