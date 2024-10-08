using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Management
{
    public class Cappuccino : Beverage
    {
        public Cappuccino() 
        {
            description = "Cappuccino";
        }

        public override double Cost()
        {
            return 7;
        }
    }
}
