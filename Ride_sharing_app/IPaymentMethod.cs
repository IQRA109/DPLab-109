using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount, Rider rider);
    }
}
