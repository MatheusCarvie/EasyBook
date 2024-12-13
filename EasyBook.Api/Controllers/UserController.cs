using EasyBook.Api.Controllers.Base;
using EasyBook.Application.Services;
using EasyBook.Domain.Dtos;
using EasyBook.Domain.Entities;
using EasyBook.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : AppControllerBase<User, UserModel, UserDto>
    {
        public UserController(UserService service) : base(service)
        {
            
        }
    }
}
