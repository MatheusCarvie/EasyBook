using EasyBook.Domain.Dtos.Base;

namespace EasyBook.Domain.Dtos
{
    public class ReturnDto : AppDtoBase
    {
        public Guid LoanId { get; set; }
        public DateTime Date { get; set; }
        public bool IsReturnedOnTime { get; set; }
    }
}
