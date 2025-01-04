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
    public class BookstoreController : AppControllerBase<Bookstore, BookstoreModel, BookstoreDto>
    {
        public BookstoreController(BookstoreService service, BookstoreValidation validation) : base(service, validation)
        {
            
        }
    }
}
