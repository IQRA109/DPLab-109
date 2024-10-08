using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Management
{
    public class Sugar: CondimentDecorator
    {
        Beverage beverage;

        public Sugar(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "Sugar";
        }
        public override double Cost()
        {
           return beverage.Cost()+ 0.20;
        }
    }
    
   
}
