using System.ComponentModel.DataAnnotations;
using Bookish.Models.Database;

namespace Bookish.Models
{
    public class Book 
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set; }
        [Url]
        public string? BookCoverUrl { get; set; }
        public List<Author>? Author { get; set; }
        public Book() { }

        public Book(BookDbModel bookDbModel)
        {
            Isbn = bookDbModel.Isbn;
            Title = bookDbModel.Title;
            BookCoverUrl = bookDbModel.BookCoverUrl;
            Year = bookDbModel.Year;
            Author = bookDbModel.Authors?.Select(a => new Author(a)).ToList();
        }
    }
    
}