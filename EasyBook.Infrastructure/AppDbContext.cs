﻿using Microsoft.EntityFrameworkCore;
using EasyBook.Domain.Entities;

namespace EasyBook.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Bookstore> Bookstores { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Return> Returns { get; set; }
    }


}
