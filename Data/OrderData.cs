using Bangthatzon.Models;

namespace Bangthatzon.Data
{
    public class OrderData
    {
        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                UserId= 1,
                PaymentTypeId= 4,
                PurchaseDate= new DateTime(2023, 10, 02),
                OpenOrder= false,
            },
            new Order
            {
                Id = 2,
                UserId= 2,
                PaymentTypeId= 1,
                PurchaseDate= new DateTime(2023, 6, 15),
                OpenOrder= false,
            },
            new Order
            {
                Id = 3,
                UserId= 2,
                PaymentTypeId= 3,
                OpenOrder= true,
            },
            new Order
            {
                Id = 4,
                UserId= 3,
                PaymentTypeId= 2,
                OpenOrder= true,
            },
        };
    }
}
