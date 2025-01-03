using EasyBook.Domain.Dtos.Base;

namespace EasyBook.Domain.Dtos
{
    public class BookstoreDto : AppDtoBase
    {
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
