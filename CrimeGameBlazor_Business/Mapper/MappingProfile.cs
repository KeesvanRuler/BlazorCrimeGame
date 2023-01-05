using AutoMapper;
using CrimeGameBlazor_DataAccess;
using CrimeGameBlazor_Models;

namespace CrimeGameBlazor_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
