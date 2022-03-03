using System.ComponentModel.DataAnnotations;
namespace Bookish.Models.Database
{
    public class BookDbModel
    {
        [Key]
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public string? BookCoverUrl { get; set; }
        public int Year { get; set; }
        public List<AuthorDbModel>? Authors {get; set; }
    }
}