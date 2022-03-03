namespace Bookish.Models.Database
{
    public class BookDbModel
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public string? BookCoverUrl { get; set; }
        public int Year { get; set; }
        public int AuthorId { get; set; }
    }
}