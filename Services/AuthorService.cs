using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
       public class AuthorService
    {
        public AuthorRepo _authors = new AuthorRepo();   

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