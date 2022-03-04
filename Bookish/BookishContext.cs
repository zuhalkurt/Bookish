using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models.Database
{
    public class BookishContext : DbContext
    {
        public DbSet<BookDbModel>? BookList { get; set; }
        public DbSet<AuthorDbModel>? Authors { get; set; }
        public DbSet<LoanDbModel>? OnLoan { get; set; }
        public DbSet<MemberDbModel>? Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Bookish;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}