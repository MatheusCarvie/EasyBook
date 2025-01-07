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
    public class UserController : AppControllerBase<User, UserModel, UserDto>
    {
        public UserController(UserService service, UserValidation validation) : base(service, validation)
        {
            
        }
    }
}
