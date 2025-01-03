using System.ComponentModel.DataAnnotations;

namespace EasyBook.Domain.Entities.Base
{
    public class AppEntityBase
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
    }
}
