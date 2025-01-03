using EasyBook.Domain.Entities.Base;

namespace EasyBook.Domain.Entities
{
    public class Book: AppEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
