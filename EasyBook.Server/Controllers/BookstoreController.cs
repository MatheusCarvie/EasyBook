using EasyBook.Server.Controllers.Base;
using EasyBook.Server.Validations;
using EasyBook.Application.Services;
using EasyBook.Domain.Dtos;
using EasyBook.Domain.Entities;
using EasyBook.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBook.Server.Controllers
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
