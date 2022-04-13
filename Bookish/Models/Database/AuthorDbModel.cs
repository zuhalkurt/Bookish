using Bookish.Models.Requests;

namespace Bookish.Models.Database
{
    public class AuthorDbModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public List<BookDbModel>? Books { get; set;}
        public AuthorDbModel() { }
        public AuthorDbModel(AuthorDbModel createAuthorRequest)
        {
            Name = createAuthorRequest.Name;
        }
    }
}