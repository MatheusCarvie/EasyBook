using EasyBook.Domain.Models.Base;

namespace EasyBook.Domain.Models
{
    public class LoanModel : AppModelBase
    {
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public DateTime Date { get; set; }
    }
}
