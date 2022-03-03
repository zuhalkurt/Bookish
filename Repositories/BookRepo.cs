using Bookish.Models.Database;
using Bookish.Models;


namespace Bookish.Repositories
{
    public class BookRepo
    {
        public List<BookDbModel> GetAllBooks()
        {
            return new List<BookDbModel>
            {
                new BookDbModel
                {
                    Isbn = "9780804139021",
                    Title = "The Martian",
                    BookCoverUrl = "https://static01.nyt.com/images/2014/02/05/books/05before-and-after-slide-T6H2/05before-and-after-slide-T6H2-superJumbo.jpg?quality=75&auto=webp&disable=upscale",
                    Year = 2011,
                    AuthorId = 1,

                },
                 new BookDbModel
                {
                    Isbn = "0333363809",
                    Title = "Wasp Factory",
                    BookCoverUrl = "https://images-na.ssl-images-amazon.com/images/I/71rZ5Ls5HnL.jpg",
                    Year = 1998,
                    AuthorId = 2,

                },
                 new BookDbModel
                {
                    Isbn = "9780007171972",
                    Title = "Fellowship of the Ring",
                    BookCoverUrl = "https://images-na.ssl-images-amazon.com/images/I/41714Ccg+hL._SY344_BO1,204,203,200_.jpg",
                    Year = 2011,
                    AuthorId = 3,

                }
            };
        }
    }
}