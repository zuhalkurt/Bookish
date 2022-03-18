using Bookish.Repositories;
using Bookish.Models;
using Bookish.Models.Requests;
using Bookish.Models.Database;

namespace Bookish.Services
{
    public interface IBookService
    {
        public List<Book> GetAllBooks();
        public Book CreateBook(CreateBookRequest createBookRequest);
    }

    public class BookService : IBookService
    {
        private IBookRepo _books;
        private IAuthorRepo _authors;

        public BookService(IBookRepo books, IAuthorRepo authors)
        {
            _books = books;
            _authors = authors;
        }

        public List<Book> GetAllBooks()
        {
            var allDbBooks = _books.GetAllBooks();

            List<Book> result = new List<Book>();

            foreach (var dbBook in allDbBooks)
            {
                result.Add(new Book(dbBook));
            }

            return result;
        }
    
        public Book CreateBook(CreateBookRequest createBookRequest)
        {
            var insertedBook = _books.CreateBook(createBookRequest);

            return new Book(insertedBook);
        }
    }
}