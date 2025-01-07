using EasyBook.Domain.Entities.Base;

namespace EasyBook.Domain.Entities
{
    public class Bookstore : AppEntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
