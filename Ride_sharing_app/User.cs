using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double  Rating { get; set; }
        
        public void calculateRating(double rating)
        {
            this.Rating = rating;
        }
    }
}
