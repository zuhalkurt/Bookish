using System.ComponentModel.DataAnnotations;
namespace Bookish.Models.Database
{
    public class LoanDbModel
    {
        public int Id { get; set; }
        public MemberDbModel? Members { get; set; }
        public BookDbModel? Books { get; set; }

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