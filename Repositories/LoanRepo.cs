using Bookish.Models.Database;
namespace Bookish.Repositories
{
    public class LoanRepo
    {
        public List<LoanDbModel> GetAllLoans()
        {
            return new List<LoanDbModel>
            {
                new LoanDbModel
                {
                Id = 1,
                MemberId = 1,
                AuthorId = 2,
                Isbn = "9780804139021",
                CheckedOut = DateTime.Parse("2022/02/28"),
                DueBack = DateTime.Parse("2022/03/28"),
                ReturnedOn = null
                },
                 new LoanDbModel
                {
                Id = 2,
                MemberId = 3,
                AuthorId = 2,
                Isbn = "0333363809",
                CheckedOut = DateTime.Parse("2022/02/28"),
                DueBack = DateTime.Parse("2022/03/28"),
                ReturnedOn = null
                },
                new LoanDbModel
                {
                Id = 3,
                MemberId = 2,
                AuthorId = 1,
                Isbn = "9780007171972",
                CheckedOut = DateTime.Parse("2022/02/28"),
                DueBack = DateTime.Parse("2022/03/28"),
                ReturnedOn = null
                }
            };
        }
    }
}
