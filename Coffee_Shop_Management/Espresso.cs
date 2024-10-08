using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Management
{
    public class Espresso : Beverage
    {
        public Espresso() 
        {
            description = "Espresso";
        }
        public override double Cost()
        {
            return 5;
        }

    }
}
