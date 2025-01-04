using EasyBook.Application.Services.Base;
using EasyBook.Domain.Dtos;
using EasyBook.Domain.Entities;
using EasyBook.Domain.Models;
using EasyBook.Infrastructure.Repositorys;

namespace EasyBook.Application.Services
{
    public class LoanService : AppServiceBase<Loan, LoanModel, LoanDto>
    {
        public LoanService(LoanRepository repository) : base(repository)
        {
            
        }
    }
}
