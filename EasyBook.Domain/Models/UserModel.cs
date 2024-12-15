using EasyBook.Domain.Models.Base;

namespace EasyBook.Domain.Models
{
    public class UserModel : AppModelBase
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
