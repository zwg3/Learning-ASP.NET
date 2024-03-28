using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Bid
    {
        // ID заявки
        [Required]
        public virtual int BidId { get; set; }
        // Имя заявителя
        [Required]
        [DisplayName("Имя заявителя")]
        public virtual string Name { get; set; }

        // Название кредита
        [Required]
        [DisplayName("Название кредита")]

        public virtual string CreditHead { get; set; }
        // Дата подачи заявки
        [Required]
        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public virtual DateTime bidDate { get; set; }
    }
}
