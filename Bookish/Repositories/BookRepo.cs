using Bookish.Models.Database;
using Bookish.Models.Requests;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public interface IBookRepo
    {
        public List<BookDbModel> GetAllBooks();
        public BookDbModel CreateBook(CreateBookRequest newBook);
    }
    public class BookRepo : IBookRepo
    {
        private BookishContext context = new BookishContext();
        public List<BookDbModel> GetAllBooks()
        {
            return context
             .BookList
             .Include(b => b.Authors)
             .ToList();
        } 
        public BookDbModel CreateBook(CreateBookRequest createBookRequest)
        {
            var newBook = new BookDbModel
            {
                Isbn = createBookRequest.Isbn,
                Title = createBookRequest.Title,
                BookCoverUrl = createBookRequest.BookCoverUrl,
                Year = createBookRequest.Year
            };
            
            var insertedBook = context.Add(newBook).Entity;

            if (createBookRequest.AuthorIds != null)
            {
                insertedBook.Authors = new List<AuthorDbModel>();
                foreach(int authorId in createBookRequest.AuthorIds)
                {
                
                    insertedBook.Authors.Add(
                        context.Authors.Where(a => a.Id == authorId).Single()
                    );
                }
            }
            context.SaveChanges();
            return insertedBook;
        }
    }
}