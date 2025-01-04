using AutoMapper;
using EasyBook.Domain.Dtos;
using EasyBook.Domain.Entities;
using EasyBook.Domain.Models;
using EasyBook.Infrastructure.Repositorys.Base;

namespace EasyBook.Infrastructure.Repositorys
{
    public class ReturnRepository : AppRepositoryBase<Return, ReturnModel, ReturnDto>
    {
        public ReturnRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
    }
}
