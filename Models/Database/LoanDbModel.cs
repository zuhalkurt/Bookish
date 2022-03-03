using Bookish.Models;
namespace Bookish.Models.Database
{
    public class LoanDbModel
    {
        public int Id { get; set; }
        public int? MemberId { get; set; }
        public string? Isbn { get; set; }
        public int? AuthorId { get; set; }
        public DateTime? CheckedOut { get; set; }
        public DateTime? DueBack { get; set; }
        public DateTime? ReturnedOn { get; set; }
    }
}