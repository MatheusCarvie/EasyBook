using Microsoft.EntityFrameworkCore;
using EasyBook.Domain.Entities;

namespace EasyBook.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> User { get; set; }
    }


}
