using EasyBook.Domain.Models.Base;

namespace EasyBook.Domain.Models
{
    public class BookModel : AppModelBase
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public Guid BookstoreId { get; set; }
    }
}
