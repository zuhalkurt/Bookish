using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public class BookService
    {
        private BookRepo _books  = new BookRepo();
        private AuthorRepo _authors = new AuthorRepo();

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
                   .Select(a => new Author
                   {
                       Name = a.Name
                   }).ToList(),
               });
               
           }
            return result;
        }

    }
}