using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public class BookService
    {
        public BookRepo _books  = new BookRepo();
        public AuthorRepo _authors = new AuthorRepo();

        public List<Book> GetAllBooks()
        {
            var dbBooks = _books.GetAllBooks();
            var dbAuthors = _authors.GetAllAuthors();

            List<Book> result = new List<Book>();
            foreach (var dbBook in dbBooks)
            {
                var dbAuthor = dbAuthors.Find( a => a.Id == dbBook.AuthorId);
                if (dbAuthor == null)
                {
                    throw new NullReferenceException("Could not find author");
                }
                
                result.Add(new Book
                {
                    Isbn = dbBook.Isbn,
                    Title = dbBook.Title,
                    Author = new Author
                    {
                        Name = dbAuthor.Name
                    },
                    Year = dbBook.Year,
                    BookCoverUrl = dbBook.BookCoverUrl,
                });
            }
            return result;
        }

    }
}