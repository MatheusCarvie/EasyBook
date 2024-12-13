using AutoMapper;
using EasyBook.Domain.Entities;
using EasyBook.Domain.Models;

namespace EasyBook.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserModel, User>();
        }
    }
}
