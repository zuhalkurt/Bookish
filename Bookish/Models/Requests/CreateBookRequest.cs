using System.ComponentModel.DataAnnotations;

namespace Bookish.Models.Requests
{
    public class CreateBookRequest
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public string? BookCoverUrl { get; set; }
        public List<int>? AuthorIds { get; set; }
        public  int Year { get; set ;}
    }
}