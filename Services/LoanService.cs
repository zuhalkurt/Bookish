using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public class LoanService
    {
        public LoanRepo loans  = new LoanRepo();
        public MemberRepo members = new MemberRepo();
        public BookRepo books = new BookRepo();
        public AuthorRepo authors = new AuthorRepo();

        public List<Loan> GetAllLoans()
        {
            var dbLoans = loans.GetAllLoans();
            var dbMembers = members.GetAllMembers();
            var dbBooks = books.GetAllBooks();
            var dbAuthors = authors.GetAllAuthors();

            List<Loan> result = new List<Loan>();
            foreach (var dbLoan in dbLoans)
            {   
                var dbMember = dbMembers.Find( a => a.Id == dbLoan.MemberId);
                if (dbMember == null)
                {
                    throw new NullReferenceException("Could not find member");
                }
                var dbBook = dbBooks.Find( a => a.Isbn == dbLoan.Isbn);
                if (dbBook == null)
                {
                    throw new NullReferenceException("Could not find book");
                }
                var dbAuthor = dbAuthors.Find( a => a.Id == dbLoan.AuthorId);
                if (dbAuthor == null)
                {
                    throw new NullReferenceException("Could not find author");
                }
                
                result.Add(new Loan
                {
                    Member = new Member
                    {
                        Name = dbMember.Name
                    },
                    Book = new Book
                    {
                        Title = dbBook.Title,
                        Author = new Author
                        {
                            Name = dbAuthor.Name                            
                        }
                    },
                    CheckedOut = dbLoan.CheckedOut,
                    DueBack = dbLoan.DueBack,
                    ReturnedOn = dbLoan.ReturnedOn,
                });
            }
            return result;
        }

    }
}