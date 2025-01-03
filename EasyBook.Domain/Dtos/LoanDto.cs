using EasyBook.Domain.Dtos.Base;

namespace EasyBook.Domain.Dtos
{
    public class LoanDto : AppDtoBase
    {
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public DateTime Date { get; set; }
    }
}
