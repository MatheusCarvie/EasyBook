using AutoMapper;
using EasyBook.Domain.Dtos;
using EasyBook.Domain.Entities;
using EasyBook.Domain.Models;
using EasyBook.Infrastructure.Repositorys.Base;

namespace EasyBook.Infrastructure.Repositorys
{
    public class LoanRepository : AppRepositoryBase<Loan, LoanModel, LoanDto>
    {
        public LoanRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
    }
}
