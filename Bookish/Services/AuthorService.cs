using Bookish.Repositories;
using Bookish.Models;
using Bookish.Models.Requests;
using Bookish.Models.Database;

namespace Bookish.Services
{
    public interface IAuthorService
    {
        public List<Author> GetAllAuthors();
        public AuthorDbModel CreateAuthor(CreateAuthorRequest createAuthorRequest);
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
            var allDbAuthors = _authors.GetAllAuthors();

            foreach (var dbAuthor in allDbAuthors)
            {
                 authors.Add(
                    new Author(dbAuthor)
                );
            }
            return authors;
        }
        public AuthorDbModel CreateAuthor(CreateAuthorRequest createAuthorRequest)
        {
            var insertedAuthor = _authors.CreateAuthor(createAuthorRequest);
            return new AuthorDbModel(insertedAuthor);
        }
    }
}