using EasyBook.Domain.Models.Base;

namespace EasyBook.Domain.Models
{
    public class BookstoreModel : AppModelBase
    {
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
