using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public interface ILoanService
    {
        public List<Loan> GetAllLoans();
    }
    public class LoanService : ILoanService
    {
        private ILoanRepo _loans;
        private IMemberRepo _members;
        private IBookRepo _books;
        private IAuthorRepo _authors;
        public LoanService(ILoanRepo loans)
        {
            _loans = loans;
            _members = new MemberRepo();
            _books = new BookRepo();
            _authors = new AuthorRepo();
        }
        
        // private LoanRepo _loans  = new LoanRepo();
        // private MemberRepo _members = new MemberRepo();
        // private BookRepo _books = new BookRepo();
        //private AuthorRepo _authors = new AuthorRepo();

        public List<Loan> GetAllLoans()
        {
            var dbLoans = _loans.GetAllLoans();
            var dbMembers = _members.GetAllMembers();
            var dbBooks = _books.GetAllBooks();
            var dbAuthors = _authors.GetAllAuthors();

            List<Loan> result = new List<Loan>();

            foreach (var dbLoan in dbLoans)
            {   
               
                result.Add(new Loan
                {
                    Member = new Member 
                    {
                        Name = dbLoan.Members.Name,
                        Email = dbLoan.Members.Email,
                        PhoneNumber = dbLoan.Members.PhoneNumber

                    },
                    Book = new Book
                    {
                        Title = dbLoan.Books.Title,
                        Authors = dbLoan.Books
                            .Authors
                            .Select(
                                a => new Author
                                {
                                    Name = a.Name                         
                                })
                            .ToList(),

                    },
                    CheckedOut = dbLoan.CheckedOut,
                    DueBack = dbLoan.DueBack,
                    
                });
                
            }
            return result;
        }
    
    }
}