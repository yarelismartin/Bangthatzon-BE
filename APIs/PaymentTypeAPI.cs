using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using Bangthatzon.Models;


namespace Bangthatzon.APIs
{
    public class PaymentTypeAPI
    {
        public static void Map(WebApplication app)
        {
            //Get payment type by userId // checkout drop down
            app.MapGet("/api/users/{userId}/payment-types", (BangthatzonDbContext db, int userId) =>
            {
                var usersPaymentTypes = db.PaymentTypes
                .Where(p => p.UserId == userId)
                .ToList();
                if (!usersPaymentTypes.Any())
                {
                    return Results.NotFound();
                }
                return Results.Ok(usersPaymentTypes);
            });
        }
    }
}
