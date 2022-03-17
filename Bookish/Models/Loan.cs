using System.ComponentModel.DataAnnotations;
namespace Bookish.Models
{
    public class Loan 
    {
        public Member? Member { get; set; }
        public Book? Book { get; set; }

        [DataType(DataType.Date)]  
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)] 
        public DateTime? CheckedOut { get; set; }

        [DataType(DataType.Date)]  
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)] 
        public DateTime? DueBack { get; set; }
        
        [DataType(DataType.Date)]  
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)] 
        public DateTime? ReturnedOn { get; set; }
      
    }

}