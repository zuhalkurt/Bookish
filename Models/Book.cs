namespace Bookish.Models
{
    public class Book 
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public Author? Author { get; set; }
        public int Year { get; set; }
        public string? BookCoverUrl { get; set; }
    }
}