using Bangthatzon.Models;

namespace Bangthatzon.Data
{
    public class PaymentTypeData
    {
        public static List<PaymentType> PaymentTypes = new List<PaymentType>
        {
            new PaymentType { Id = 1, CardNumber = "1234567812345678", UserId = 2},
            new PaymentType { Id = 2, CardNumber = "2345678923456789", UserId = 3},
            new PaymentType { Id = 3, CardNumber = "3456789034567890", UserId = 2},
            new PaymentType { Id = 4, CardNumber = "4567890145678901", UserId = 1},
        };
    }
}
