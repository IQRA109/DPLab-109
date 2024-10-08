using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Management
{
    public abstract class Beverage
    {
        protected string description;

        public virtual string getDescription()
        { 
            return description;
        }

        public abstract double Cost();
    }
}
