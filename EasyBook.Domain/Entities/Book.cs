using EasyBook.Domain.Entities.Base;

namespace EasyBook.Domain.Entities
{
    public class Book: AppEntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public Guid BookstoreId { get; set; }
        public Bookstore Bookstore { get; set; } = new Bookstore();
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
