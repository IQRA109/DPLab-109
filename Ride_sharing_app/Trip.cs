using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public class Trip
    {
        public int Id { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public RideType RideType { get; set; }
        public TripStatus Status { get; set; }
        public Rider Rider { get; set; }
        public Driver Driver { get; set; }
        public double Fare {  get; set; }

        public Trip(int id, string pickupLocation, string dropoffLocation, RideType rideType, TripStatus status, Rider rider, Driver driver, double fare)
        {
            Id = id;
            PickupLocation = pickupLocation;
            DropoffLocation = dropoffLocation;
            RideType = rideType;
            Status = status;
            Rider = rider;
            Driver = driver;
            Fare = fare;
        }

        public void AssignDriver(Driver driver)
        {
            Driver = driver;
            driver.AcceptRide(this);
        }
        public void CalculateFare()
        {
            Fare = 30.0;
            Console.WriteLine($"Fare is = {Fare}");
        }
    }
}
