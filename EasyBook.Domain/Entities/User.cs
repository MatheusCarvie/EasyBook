using EasyBook.Domain.Entities.Base;

namespace EasyBook.Domain.Entities
{
    public class User : AppEntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string .Empty;
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
        public Bookstore Bookstore { get; set; }
    }
}
