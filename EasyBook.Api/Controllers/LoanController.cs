using EasyBook.Api.Controllers.Base;
using EasyBook.Api.Validations;
using EasyBook.Application.Services;
using EasyBook.Domain.Dtos;
using EasyBook.Domain.Entities;
using EasyBook.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : AppControllerBase<Loan, LoanModel, LoanDto>
    {
        public LoanController(LoanService service, LoanValidation validation) : base(service, validation)
        {
            
        }
    }
}
