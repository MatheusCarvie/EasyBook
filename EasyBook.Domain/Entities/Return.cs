using EasyBook.Domain.Entities.Base;

namespace EasyBook.Domain.Entities
{
    public class Return : AppEntityBase
    {
        public Guid LoanId { get; set; }
        public Loan Loan { get; set; } = new Loan();
        public DateTime Date { get; set; }
        public bool IsReturnedOnTime { get; set; }
    }
}
