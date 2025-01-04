using EasyBook.Application.Services.Base;
using EasyBook.Domain.Dtos;
using EasyBook.Domain.Entities;
using EasyBook.Domain.Models;
using EasyBook.Infrastructure.Repositorys;

namespace EasyBook.Application.Services
{
    public class ReturnService : AppServiceBase<Return, ReturnModel, ReturnDto>
    {
        public ReturnService(ReturnRepository repository) : base(repository)
        {
            
        }
    }
}
