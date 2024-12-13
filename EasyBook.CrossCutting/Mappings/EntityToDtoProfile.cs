using AutoMapper;
using EasyBook.Domain.Dtos;
using EasyBook.Domain.Entities;

namespace EasyBook.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
