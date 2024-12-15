using EasyBook.Domain.Dtos.Base;

namespace EasyBook.Domain.Dtos
{
    public class UserDto : AppDtoBase
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
