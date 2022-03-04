using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public interface IBookService
    {
        public List<Book> GetAllBooks();
    }
    public class BookService : IBookService
    {
        private IBookRepo _books;

        public BookService(IBookRepo books)
        {
            _books = books;
        }
        public List<Book> GetAllBooks()
        {
           var allDBBooks = _books.GetAllBooks();

           List<Book> result = new List<Book>();

           foreach (var dbBook in allDBBooks)
           {
               result.Add(new Book
               {
                   Isbn = dbBook.Isbn,
                   Title = dbBook.Title,
                   BookCoverUrl = dbBook.BookCoverUrl,
                   Year = dbBook.Year,
                   Author = dbBook
                        .Authors
                        .Select(
                            a => new Author
                            {
                                Name = a.Name
                            })
                        .ToList(),
               });
               
           }
            return result;
        }

    }
}