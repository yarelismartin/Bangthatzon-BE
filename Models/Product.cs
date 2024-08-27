using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bangthatzon.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public int QuantityAvailable { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int SellerId { get; set; }
        public User Seller { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Order> Orders { get; set; } 

    }
}
