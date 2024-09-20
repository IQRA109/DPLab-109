using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public class PayPalPayment : IPaymentMethod
    {
       public void ProcessPayment(double amount, Rider rider)
        {
            Console.WriteLine($"Processing PayPal payment of {amount} for {rider.Name}");
        }
    }
}
