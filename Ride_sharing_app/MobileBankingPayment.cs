using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public class MobileBankingPayment : IPaymentMethod
    {
         public void ProcessPayment(double amount, Rider rider)
        {
            Console.WriteLine($"Processing Mobile Banking Payment of {amount} from {rider.Name}");
        }
    }
}
