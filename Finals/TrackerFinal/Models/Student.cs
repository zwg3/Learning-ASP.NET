using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrackerFinal.Models
{
    public class Student
    {
        public virtual int Id { get; set; }
        [DisplayName("ФИО")]
        [RegularExpression(@"([^\s]+ ){2}[^\s]+", ErrorMessage = "Необходимо указать ФИО студента алфавитными буквами через пробел")]
        public virtual string Fullname { get; set; }
        [DisplayName("Математика")]
        //[RegularExpression(@"([1-5])", ErrorMessage = "Необходимо указать оценку от 1 до 5")]
        public virtual int Math { get; set; }
        [DisplayName("Русский язык")]
        //[RegularExpression(@"([1-5])", ErrorMessage = "Необходимо указать оценку от 1 до 5")]
        public virtual int Russian { get; set; }
        [DisplayName("Английский язык")]
        //[RegularExpression(@"([1-5])", ErrorMessage = "Необходимо указать оценку от 1 до 5")]
         public virtual int English { get; set; }
        [DisplayName("Химия")]
        //[RegularExpression(@"([1-5])", ErrorMessage = "Необходимо указать оценку от 1 до 5")]
        public virtual int Chemistry { get; set; }       

    }   
       

}
