using Bookish.Models.Database;
namespace Bookish.Repositories
{
    public class AuthorRepo
    {
        public List<AuthorDbModel> GetAllAuthors()
        {
            return new List<AuthorDbModel>
            {
                new AuthorDbModel
                {
                    Id = 1,
                    Name = "Andy Weir",
                },
                 new AuthorDbModel
                {
                    Id = 2,
                    Name = "Iain Banks",
                },
                new AuthorDbModel
                {
                    Id = 3,
                    Name = "J. R. R Tolkien",
                }
            };
        }
    }
}