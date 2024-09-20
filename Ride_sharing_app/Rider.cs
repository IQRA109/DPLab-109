using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public class Rider : User
    {
        public string Location {  get; set; }
        public Rider(string location)
        {
            Location = location;
        }

        public void RequestRide(RideType rideType, string pickup, string dropoff)
        {
            Console.WriteLine($"{Name} requested a {rideType} from {pickup} to {dropoff}");
        }

        public void rateDriver(Driver driver, double rating)
        {
            driver.Rating = (driver.Rating + rating) / 2;
            Console.WriteLine( $"{Name} rated driver {driver.Name} with {rating} stars");
        }

       // public void MakePayment()
    }
}
