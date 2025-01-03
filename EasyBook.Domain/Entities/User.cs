using EasyBook.Domain.Entities.Base;

namespace EasyBook.Domain.Entities
{
    public class User : AppEntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string .Empty;
        public ICollection<Book> Books { get; set; }
    }
}
