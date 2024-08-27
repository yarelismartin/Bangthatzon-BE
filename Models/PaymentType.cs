using System.ComponentModel.DataAnnotations;

namespace Bangthatzon.Models
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
