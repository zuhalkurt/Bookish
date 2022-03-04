using Bookish.Models;
namespace Bookish.Models.Database
{
    public class LoanDbModel
    {
        public int Id { get; set; }
        public MemberDbModel? Members { get; set; }
        public BookDbModel? Books { get; set; }
        public DateTime? CheckedOut { get; set; }
        public DateTime? DueBack { get; set; }
        public DateTime? ReturnedOn { get; set; }
    }
}