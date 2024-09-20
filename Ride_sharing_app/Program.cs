using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public enum TripStatus { Requested, Accepted, InProgress, Completed }

    public enum NotificationType { SMS, Email, InApp }

    public enum RideType { Carpool, LuxuryRide, BikeRide }
    public class Program
    {
        public static void Main(string[] args)
        {
            RideSharingAppTest.RunTests();
            Console.ReadKey();
        }
    }
}



