using Bangthatzon.Models;

namespace Bangthatzon.Data
{
    public class ProductData
    {
        public static List<Product> Products = new List<Product>
        {
             new Product
            {
                Id = 1,
                ProductName = "Smartphone",
                Description = "Latest model with all the features",
                Image = "smartphone.jpg",
                QuantityAvailable = 50,
                Price = 699.99m,
                CreatedDate = new DateTime(2024, 8, 1),
                SellerId = 4,
                CategoryId = 1,
            },
            new Product
            {
                Id = 2,
                ProductName = "Coffee Maker",
                Description = "Brews coffee in minutes",
                Image = "coffee_maker.jpg",
                QuantityAvailable = 20,
                Price = 89.99m,
                CreatedDate = new DateTime(2024, 8, 3),
                SellerId = 5,
                CategoryId = 3,
            },
            new Product
            {
                Id = 3,
                ProductName = "Headphones",
                Description = "Noise-cancelling over-ear headphones",
                Image = "headphones.jpg",
                QuantityAvailable = 30,
                Price = 149.99m,
                CreatedDate = new DateTime(2024, 8, 5),
                SellerId = 6,
                CategoryId = 1,

            },
            new Product
            {
                Id = 4,
                ProductName = "Yoga Mat",
                Description = "High-quality mat for yoga and workouts",
                Image = "yoga_mat.jpg",
                QuantityAvailable = 40,
                Price = 39.99m,
                CreatedDate = new DateTime(2024, 8, 7),
                SellerId = 7,
                CategoryId = 5,

            },
            new Product
            {
                Id = 5,
                ProductName = "Wireless Charger",
                Description = "Fast wireless charger for all devices",
                Image = "wireless_charger.jpg",
                QuantityAvailable = 25,
                Price = 29.99m,
                CreatedDate = new DateTime(2024, 8, 9),
                SellerId = 8,
                CategoryId = 1,

            },
            new Product
            {
                Id = 6,
                ProductName = "Camping Tent",
                Description = "Durable tent for outdoor camping",
                Image = "camping_tent.jpg",
                QuantityAvailable = 15,
                Price = 119.99m,
                CreatedDate = new DateTime(2024, 8, 11),
                SellerId = 9,
                CategoryId = 5,

            },
            new Product
            {
                Id = 7,
                ProductName = "Smartwatch",
                Description = "Stylish smartwatch with fitness tracking",
                Image = "smartwatch.jpg",
                QuantityAvailable = 22,
                Price = 249.99m,
                CreatedDate = new DateTime(2024, 8, 13),
                SellerId = 10,
                CategoryId = 1,

            }
        };
    }
}
