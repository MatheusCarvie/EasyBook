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
            CreateMap<BookModel, Book>();
            CreateMap<BookstoreModel, Bookstore>();
            CreateMap<LoanModel, Loan>();
            CreateMap<ReturnModel, Return>();
        }
    }
}
