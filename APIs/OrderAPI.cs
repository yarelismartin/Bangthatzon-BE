using Bangthatzon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Runtime.CompilerServices;

namespace Bangthatzon.APIs
{
    public class OrderAPI
    {
        public static void Map(WebApplication app)
        {
            //Get open order by userId, if order == null then create order
            //used when you click on the cart
            app.MapGet("/api/users/{userId}/orders/open", (BangthatzonDbContext db, int userId) =>
            {
                Order openOrder = db.Orders
                .Include(o => o.Products)
                .ThenInclude(p => p.Seller)
                .SingleOrDefault(o => o.UserId == userId && o.OpenOrder == true);

                if (openOrder == null)
                {
                    Order newOrder = new Order();
                    newOrder.UserId = userId;
                    newOrder.OpenOrder = true;
                    db.Orders.Add(newOrder);
                    db.SaveChanges();
                    return Results.Ok(newOrder);
                }
                else
                    return Results.Ok(openOrder);
            });

            //Patch order / updtate payment type, openorder, and date purchased
            app.MapPatch("/api/orders/{orderId}/place", (BangthatzonDbContext db, int orderId, Order placedOrder) =>
             {
                 Order orderToPlace = db.Orders.SingleOrDefault(o => o.Id == orderId);
                 if (orderToPlace == null)
                 {
                     return Results.BadRequest("Order not found.");
                 }
                 orderToPlace.PaymentTypeId = placedOrder.PaymentTypeId;
                 orderToPlace.OpenOrder = false;
                 orderToPlace.PurchaseDate = DateTime.Now;
                 db.SaveChanges();
                 return Results.Ok(orderToPlace);

             });


            //Get order by id / checkout summary of order that was just placed/completed
            app.MapGet("/api/orders/completed/{orderId}", (BangthatzonDbContext db, int orderId) =>
            {
                Order completedOrder = db.Orders
                .Include(o => o.Products)
                .SingleOrDefault(o => o.Id == orderId);

                if (completedOrder == null)
                {
                    return Results.NotFound("Order not found.");
                }
                return Results.Ok(completedOrder);
            });

            //Get order by user id and if it's closed / order history
            app.MapGet("/api/users/{userId}/orders/closed", (BangthatzonDbContext db, int userId) =>
            {
                var orderHistory = db.Orders
                .Include(o => o.Products)
                .Where(o => o.UserId == userId && o.OpenOrder == false)
                .OrderBy(o => o.PurchaseDate)
                .ToList();
                if (orderHistory == null)
                {
                    return Results.NotFound("No orders have been closed ");
                }
                return Results.Ok(orderHistory);
            });
        }
    }
}
