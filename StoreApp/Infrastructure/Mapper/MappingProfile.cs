using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace StoreApp.Insfrastructer.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDtoForInsertion,Product>().ReverseMap();
            CreateMap<ProductDtoForUpdate,Product>().ReverseMap();
        }
    }
}