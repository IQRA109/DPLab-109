using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public class Driver : User
    {
        public string VehicleType { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Driver(string vehicleType, string location, bool isAvailable)
        {
            VehicleType = vehicleType;
            Location = location;
            IsAvailable = isAvailable;
        }
        public void AcceptRide(Trip trip)
        {
            IsAvailable = false;
        }
        //public void startTrip()
        //public void CompleteTrip()
        //public void rateRider()
    }



}
