using Bookish.Models.Database;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public class AuthorRepo
    {
        private BookishContext context = new BookishContext();
        public List<AuthorDbModel> GetAllAuthors()
        {
            return context
             .Authors
             .Include(a => a.Books)
             .ToList();
        } 
    }
}