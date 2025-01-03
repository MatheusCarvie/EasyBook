using EasyBook.Domain.Dtos.Base;

namespace EasyBook.Domain.Dtos
{
    public class BookDto : AppDtoBase
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public Guid BookstoreId { get; set; }
    }
}
