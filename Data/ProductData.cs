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
                Image = "https://images.unsplash.com/photo-1535240073203-05bc5d7f1113?q=80&w=1336&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
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
                Image = "https://images.pexels.com/photos/5825347/pexels-photo-5825347.jpeg?auto=compress&cs=tinysrgb&w=400",
                QuantityAvailable = 20,
                Price = 489.99m,
                CreatedDate = new DateTime(2024, 8, 3),
                SellerId = 5,
                CategoryId = 3,
            },
            new Product
            {
                Id = 3,
                ProductName = "Headphones",
                Description = "Noise-cancelling over-ear headphones",
                Image = "https://images.pexels.com/photos/3574678/pexels-photo-3574678.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
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
                Image = "https://images.pexels.com/photos/6740735/pexels-photo-6740735.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
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
                Image = "https://images.unsplash.com/photo-1677870367958-11dd9592089d?q=80&w=1287&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
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
                Image = "https://images.pexels.com/photos/5994745/pexels-photo-5994745.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
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
                Image = "https://images.unsplash.com/photo-1650043079035-a97c338caa6a?q=80&w=1349&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 22,
                Price = 249.99m,
                CreatedDate = new DateTime(2024, 8, 13),
                SellerId = 10,
                CategoryId = 1,

            },
            new Product
            {
                Id = 8,
                ProductName = "Running Shoes",
                Description = "Comfortable and durable running shoes",
                Image = "https://images.unsplash.com/photo-1582898967731-b5834427fd66?q=80&w=1287&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 60,
                Price = 79.99m,
                CreatedDate = new DateTime(2024, 8, 15),
                SellerId = 3,
                CategoryId = 2,
            },
            new Product
            {
                Id = 9,
                ProductName = "Blender",
                Description = "High-speed blender for smoothies",
                Image = "https://images.pexels.com/photos/6802634/pexels-photo-6802634.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                QuantityAvailable = 45,
                Price = 99.99m,
                CreatedDate = new DateTime(2024, 8, 17),
                SellerId = 5,
                CategoryId = 3,
            },
            new Product
            {
                Id = 10,
                ProductName = "https://images.pexels.com/photos/20092852/pexels-photo-20092852/free-photo-of-an-e-book-reader-lying-on-an-open-book.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                Description = "Portable e-book reader with backlight",
                Image = "ebook_reader.jpg",
                QuantityAvailable = 33,
                Price = 129.99m,
                CreatedDate = new DateTime(2024, 8, 19),
                SellerId = 2,
                CategoryId = 4,
            },
            new Product
            {
                Id = 11,
                ProductName = "Basketball",
                Description = "Official size and weight basketball",
                Image = "https://images.unsplash.com/photo-1574623452334-1e0ac2b3ccb4?q=80&w=1287&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 50,
                Price = 29.99m,
                CreatedDate = new DateTime(2024, 8, 21),
                SellerId = 7,
                CategoryId = 5,
            },
            new Product
            {
                Id = 12,
                ProductName = "Gaming Console",
                Description = "Next-gen gaming console with 4K support",
                Image = "https://images.unsplash.com/photo-1531390658120-e06b58d826ea?q=80&w=1289&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 10,
                Price = 499.99m,
                CreatedDate = new DateTime(2024, 8, 23),
                SellerId = 6,
                CategoryId = 1,
            },
            new Product
            {
                Id = 13,
                ProductName = "Leather Jacket",
                Description = "Stylish leather jacket for men",
                Image = "https://images.pexels.com/photos/25244457/pexels-photo-25244457/free-photo-of-low-angle-shot-of-woman-bending-in-leather-jacket.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                QuantityAvailable = 25,
                Price = 199.99m,
                CreatedDate = new DateTime(2024, 8, 25),
                SellerId = 8,
                CategoryId = 2,
            },
            new Product
            {
                Id = 14,
                ProductName = "Digital Camera",
                Description = "Compact digital camera with 20MP resolution",
                Image = "https://images.unsplash.com/photo-1608204726950-be65410207a7?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 12,
                Price = 299.99m,
                CreatedDate = new DateTime(2024, 8, 27),
                SellerId = 9,
                CategoryId = 1,
            },
            new Product
            {
                Id = 15,
                ProductName = "Cookware Set",
                Description = "Non-stick cookware set for all your cooking needs",
                Image = "https://images.unsplash.com/photo-1588279102819-f4520e40b1c6?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 20,
                Price = 149.99m,
                CreatedDate = new DateTime(2024, 8, 29),
                SellerId = 5,
                CategoryId = 3,
            },
            new Product
            {
                Id = 16,
                ProductName = "Treadmill",
                Description = "Foldable treadmill with multiple speed settings",
                Image = "https://images.unsplash.com/photo-1637579674775-7f868ee3c92d?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 8,
                Price = 599.99m,
                CreatedDate = new DateTime(2024, 8, 31),
                SellerId = 10,
                CategoryId = 5,
            },
            new Product
            {
                Id = 17,
                ProductName = "Bluetooth Speaker",
                Description = "Portable Bluetooth speaker with deep bass",
                Image = "https://images.unsplash.com/photo-1683643270108-efc9d3be15fb?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 70,
                Price = 89.99m,
                CreatedDate = new DateTime(2024, 9, 2),
                SellerId = 4,
                CategoryId = 1,
            },
            new Product
            {
                Id = 18,
                ProductName = "Smart Light Bulbs",
                Description = "WiFi-enabled smart light bulbs with color change",
                Image = "https://plus.unsplash.com/premium_photo-1661904010103-326ba87f7df4?q=80&w=988&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 100,
                Price = 49.99m,
                CreatedDate = new DateTime(2024, 9, 4),
                SellerId = 3,
                CategoryId = 1,
            },
            new Product
            {
                Id = 19,
                ProductName = "Electric Kettle",
                Description = "Fast boiling electric kettle with auto shut-off",
                Image = "https://images.unsplash.com/photo-1592417766326-088bf3da80c5?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 30,
                Price = 29.99m,
                CreatedDate = new DateTime(2024, 9, 6),
                SellerId = 6,
                CategoryId = 3,
            },
            new Product
            {
                Id = 20,
                ProductName = "Running Shorts",
                Description = "Breathable running shorts for men",
                Image = "https://images.unsplash.com/photo-1595571024048-45a59177f538?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 40,
                Price = 24.99m,
                CreatedDate = new DateTime(2024, 9, 8),
                SellerId = 8,
                CategoryId = 2,
            },
            new Product
            {
                Id = 21,
                ProductName = "Fiction Book",
                Description = "Best-selling fiction novel",
                Image = "https://images.unsplash.com/photo-1571506055055-a8d23aff671e?q=80&w=1024&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 60,
                Price = 14.99m,
                CreatedDate = new DateTime(2024, 9, 10),
                SellerId = 2,
                CategoryId = 4,
            },
            new Product
            {
                Id = 22,
                ProductName = "Tent Poles",
                Description = "Replacement tent poles for camping",
                Image = "https://plus.unsplash.com/premium_photo-1682135960800-bce2bad8c5e7?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 25,
                Price = 19.99m,
                CreatedDate = new DateTime(2024, 9, 12),
                SellerId = 9,
                CategoryId = 5,
            },
            new Product
            {
                Id = 23,
                ProductName = "Laptop",
                Description = "High-performance laptop with SSD",
                Image = "https://plus.unsplash.com/premium_photo-1681702156223-ea59bfbf1065?q=80&w=1035&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 15,
                Price = 999.99m,
                CreatedDate = new DateTime(2024, 9, 14),
                SellerId = 4,
                CategoryId = 1,
            },
            new Product
            {
                Id = 24,
                ProductName = "Winter Coat",
                Description = "Warm winter coat for extreme cold",
                Image = "https://images.unsplash.com/photo-1704371741930-982e834c664d?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzF8fFdpbnRlciUyMENvYXR8ZW58MHx8MHx8fDA%3D",
                QuantityAvailable = 35,
                Price = 149.99m,
                CreatedDate = new DateTime(2024, 9, 16),
                SellerId = 7,
                CategoryId = 2,
            },
            new Product
            {
                Id = 25,
                ProductName = "Microwave Oven",
                Description = "Compact microwave oven with presets",
                Image = "https://images.unsplash.com/photo-1599083549933-838ea352c1cc?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 22,
                Price = 129.99m,
                CreatedDate = new DateTime(2024, 9, 18),
                SellerId = 5,
                CategoryId = 3,
            },
            new Product
            {
                Id = 26,
                ProductName = "Yoga Block",
                Description = "Supportive yoga block for all levels",
                Image = "https://images.unsplash.com/photo-1639414303304-6e54ad2f63a0?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NTB8fFlvZ2ElMjBCbG9ja3xlbnwwfHwwfHx8MA%3D%3D",
                QuantityAvailable = 50,
                Price = 12.99m,
                CreatedDate = new DateTime(2024, 9, 20),
                SellerId = 6,
                CategoryId = 5,
            },
            new Product
            {
                Id = 27,
                ProductName = "Monitor",
                Description = "27-inch 4K monitor with adjustable stand",
                Image = "https://plus.unsplash.com/premium_photo-1665329006421-4e945f91885f?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 14,
                Price = 399.99m,
                CreatedDate = new DateTime(2024, 9, 22),
                SellerId = 10,
                CategoryId = 1,
            },
            new Product
            {
                Id = 28,
                ProductName = "Jeans",
                Description = "Slim fit jeans for men",
                Image = "https://images.unsplash.com/photo-1516313570236-85371711ee13?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 40,
                Price = 49.99m,
                CreatedDate = new DateTime(2024, 9, 24),
                SellerId = 3,
                CategoryId = 2,
            },
            new Product
            {
                Id = 29,
                ProductName = "Cookbook",
                Description = "Recipe book with 100+ easy meals",
                Image = "https://images.unsplash.com/photo-1590587754541-a3a4f2e0d06f?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                QuantityAvailable = 80,
                Price = 19.99m,
                CreatedDate = new DateTime(2024, 9, 26),
                SellerId = 1,
                CategoryId = 4,
            },
            new Product
            {
                Id = 30,
                ProductName = "Sunglasses",
                Description = "Lightweight running hat with moisture-wicking",
                Image = "https://images.pexels.com/photos/1864848/pexels-photo-1864848.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                QuantityAvailable = 35,
                Price = 19.99m,
                CreatedDate = new DateTime(2024, 9, 28),
                SellerId = 4,
                CategoryId = 2,
            }

        };
    }
}
