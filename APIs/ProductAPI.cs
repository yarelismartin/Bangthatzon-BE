using Microsoft.Extensions.Hosting;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore;
using Bangthatzon.Models;
using Microsoft.AspNetCore.Mvc;



namespace Bangthatzon.APIs
{
    public class ProductAPI
    {
        public static void Map(WebApplication app)
        {
            //get products and return the 20 most recently added in your home page
            app.MapGet("/api/products/recent", (BangthatzonDbContext db) =>
            {
                var recentlyAddedProducts = db.Products
                .OrderByDescending(p => p.CreatedDate)
                .Take(20)
                .ToList();
                if (recentlyAddedProducts == null)
                {
                    return Results.NotFound("There are no recent products");
                }
                return Results.Ok(recentlyAddedProducts);
            });

            //get products based on category id
            app.MapGet("/api/products/categorys/{categoryId}", (BangthatzonDbContext db, int categoryId) =>
            {
                var productsByCategory = db.Products
                .Where(p => p.CategoryId == categoryId)
                .ToList();
                if (productsByCategory == null)
                {
                    return Results.NotFound("No products to show for this category");
                }
                return Results.Ok(productsByCategory);
            });

            //get all products
            app.MapGet("/api/products", (BangthatzonDbContext db) =>
            {
                var allProducts = db.Products
                .OrderByDescending(p => p.CreatedDate)
                .ToList();
                if (allProducts == null)
                {
                    return Results.NotFound("There are no products");
                }
                return Results.Ok(allProducts);
            });

            //get product by id. Will need to ensure that it's returning the seller data in the response
            app.MapGet("/api/products/{productId}", (BangthatzonDbContext db, int productId) =>
            {
                Product product = db.Products
                .Include(p => p.Seller)
                .SingleOrDefault(p => p.Id == productId);
                if (product == null)
                {
                    return Results.NotFound("There are no product matching this id.");
                }
                return Results.Ok(product);
            });


            //get products by user id but could i just get the usersId and then the list of their products should be there ??? // seller products page
            app.MapGet("/api/products/sellers/{sellerId}", (BangthatzonDbContext db, int sellerId) =>
            {
                User sellersProducts = db.Users
                .Include(u => u.Products)
                .SingleOrDefault(u => u.Id == sellerId);
                if (sellersProducts == null)
                {
                    return Results.NotFound("There are no product being sold by this seller.");
                }
                return Results.Ok(sellersProducts);
            });


            //when a product gets added to the cart:
            //check if there is an open order and if not then create an open order
            //a patch should occur on the product to update the quantity available
            app.MapGet("/api/products/{productId}/addProduct", (BangthatzonDbContext db, int productId, int userId) =>
            {
                // Fetch the order along with its products
                var order = db.Orders
                    .Include(o => o.Products)
                    .SingleOrDefault(o => o.UserId == userId && o.OpenOrder == true);

                // Fetch the product
                var productToAdd = db.Products.Find(productId);
                
                // Check if the order or product does not exist
                if (productToAdd == null)
                {
                    return Results.NotFound("Product not found");
                }

                if (productToAdd.QuantityAvailable <= 0)
                {
                    return Results.BadRequest("Product is out of stock");
                }

                if (order == null)
                {
                    order = new Order
                    {
                        UserId = userId,
                        OpenOrder = true,

                    };
                    db.Orders.Add(order);
                    db.SaveChanges();
                }

                // Add the product to the order's products collection
                order.Products.Add(productToAdd);

                //Update the quantity of the producy
                productToAdd.QuantityAvailable -= 1;

                // Save changes to the database
                db.SaveChanges();

                // Return a success response
                return Results.Ok();
            });


            //remove product from cart and update the quantity available
            app.MapDelete("/api/orders/{orderId}/removeProduct", (BangthatzonDbContext db, int orderId, int productId) =>
            {
                var order = db.Orders
                .Include(o => o.Products)
                .SingleOrDefault(o => o.Id == orderId);

                var productToRemove = db.Products.Find(productId);

                if (order == null || productToRemove == null)
                {
                    return Results.NotFound("Order or Product not found");
                }

                if (!order.Products.Contains(productToRemove))
                {
                    return Results.BadRequest("Product not found in the order.");
                }
                order.Products.Remove(productToRemove);
                productToRemove.QuantityAvailable += 1;
                db.SaveChanges();
                return Results.Ok();

            });

        }
    }
}
