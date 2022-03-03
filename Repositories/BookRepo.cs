using Bookish.Models.Database;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public class BookRepo
    {
        private BookishContext context = new BookishContext();
        public List<BookDbModel> GetAllBooks()
        {
            return context
             .BookList
             .Include(b => b.Authors)
             .ToList();
        } 
    }
}