using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public interface ILoanRepo
    {
        public List<LoanDbModel> GetAllLoans();
    }
    public class LoanRepo : ILoanRepo
    {
        private BookishContext context = new BookishContext();
        public List<LoanDbModel> GetAllLoans()
        {
            return context
             .OnLoan
             .Include(l => l.Members)
             .Include(l => l.Books)
                .ThenInclude(a => a.Authors)
             .ToList();
        } 
    }
}