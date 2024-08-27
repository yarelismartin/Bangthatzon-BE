using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;


namespace Bangthatzon.APIs
{
    public class PaymentTypeAPI
    {
        public static void Map(WebApplication app)
        {
            //Get payment type // checkout drop down
            app.Map("/api/payment-types", (BangthatzonDbContext db) =>
            {
                var allPaymentTypes = db.PaymentTypes.ToList();
                if (allPaymentTypes == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(allPaymentTypes);
            });
        }
    }
}
