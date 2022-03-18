using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public interface IAuthorRepo
    {
        public List<AuthorDbModel> GetAllAuthors();
        public AuthorDbModel CreateAuthor(AuthorDbModel newAuthor);
        public AuthorDbModel GetById(int authorId);
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
        public AuthorDbModel GetById(int authorId)
        {
             return context
                .Authors
                .Where(a => a.Id == authorId)
                .Single();
        }
        public AuthorDbModel CreateAuthor(AuthorDbModel newAuthor)
        {
            var authorToInsert = new AuthorDbModel
            {
                Name = newAuthor.Name
            };
            var insertedAuthor = context.Authors.Add(authorToInsert);
            context.SaveChanges();
            return insertedAuthor.Entity;
        }
    }
}