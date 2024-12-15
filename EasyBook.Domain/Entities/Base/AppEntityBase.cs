namespace EasyBook.Domain.Entities.Base
{
    public class AppEntityBase
    {
        public Guid Id { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
    }
}
