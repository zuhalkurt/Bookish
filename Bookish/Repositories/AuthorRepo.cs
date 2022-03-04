using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public interface IAuthorRepo
    {
        public List<AuthorDbModel> GetAllAuthors();
    }
    public class AuthorRepo : IAuthorRepo
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