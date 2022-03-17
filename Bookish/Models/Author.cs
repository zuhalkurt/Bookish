using Bookish.Models.Database;

namespace Bookish.Models
{
    public class Author
    {
        public string? Name { get; set; }

        public Author() { }

        public Author(AuthorDbModel authorDbModel)
        {
            Name = authorDbModel.Name;
        }
    }
}