using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public interface IAuthorService
    {
        public List<Author> GetAllAuthors();
    }
    public class AuthorService : IAuthorService
    {
        private IAuthorRepo _authors;   
        public AuthorService(IAuthorRepo authors)
        {
            _authors = authors;
        }
        public List<Author> GetAllAuthors()
        {
            var authors = new List<Author>();
            var dbAuthors = _authors.GetAllAuthors();

            foreach (var author in dbAuthors)
            {
                 authors.Add(
                    new Author
                    {
                        Name = author.Name 
                    }
                );
            }
            return authors;
        }
    }
}