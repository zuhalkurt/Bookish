using Bookish.Models.Database;
namespace Bookish.Models
{
    public class Author
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public Author() { }

        public Author(AuthorDbModel authorDbModel)
        {
            Id = authorDbModel.Id;
            Name = authorDbModel.Name;
        }
    }
}