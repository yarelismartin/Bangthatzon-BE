using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bangthatzon.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int? PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public List<Product> Products { get; set; }
        public bool OpenOrder { get; set; }
        public decimal? TotalPrice
        {
            get
            {
                // first question mark (?.) safely accesses the Sum method only if Products is not null
                //double question marks (??) provide a fallback value (0) if the left side of the expression results in null
                return Products?.Sum(p => p.Price) ?? 0;
            }
        }
    }
}
