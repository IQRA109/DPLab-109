using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Management
{
    public class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Espresso();
            Console.WriteLine(beverage1.getDescription() + " $" + beverage1.Cost());
            Beverage beverage2 = new Milk(new WhippedCream(beverage1));
            Console.WriteLine(beverage2. getDescription() + beverage2.Cost());
        }

    }
    
}
