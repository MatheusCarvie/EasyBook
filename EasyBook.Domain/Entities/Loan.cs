using EasyBook.Domain.Entities.Base;

namespace EasyBook.Domain.Entities
{
    public class Loan : AppEntityBase
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
        public Guid BookId { get; set; }
        public Book Book { get; set; } = new Book();
        public DateTime Date { get; set; }
        public Return Return { get; set; } = new Return();
    }
}
