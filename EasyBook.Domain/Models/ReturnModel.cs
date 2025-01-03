using EasyBook.Domain.Models.Base;

namespace EasyBook.Domain.Models
{
    public class ReturnModel : AppModelBase
    {
        public Guid LoanId { get; set; }
        public DateTime Date { get; set; }
        public bool IsReturnedOnTime { get; set; }
    }
}
