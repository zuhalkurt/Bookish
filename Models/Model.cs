using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models
{
    public class BookishContext : DbContext
    {
        public DbSet<Book>? BookList { get; set; }
        public DbSet<Author>? Authors { get; set; }
        public DbSet<Loan>? OnLoan { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Bookish;TrustServerCertificate=True; ");
        }
    }
}