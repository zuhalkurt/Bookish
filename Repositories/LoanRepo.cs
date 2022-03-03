using Bookish.Models.Database;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public class LoanRepo
    {
        private BookishContext context = new BookishContext();
        public List<LoanDbModel> GetAllLoans()
        {
            return context
             .OnLoan
             .Include(l => l.Members)
             .Include(l => l.Books)
             .ToList();
        } 
    }
}