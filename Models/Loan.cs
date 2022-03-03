namespace Bookish.Models
{
    public class Loan 
    {
        public Member? Member { get; set; }

        public Book? Book { get; set; }
        public DateTime? CheckedOut { get; set; }
        public DateTime? DueBack { get; set; }
        public DateTime? ReturnedOn { get; set; }
      
    }

}