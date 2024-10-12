using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("Laptop", 1000, "A high-performance Laptop");
            var product2 = new Product("Phone", 500, "A latest model smartphone");

            var bundle1 = new Bundle("A holiday gift set", "Tech Products", 0.5);
            bundle1.Add(product1);
            bundle1.Add(product2);



            Console.WriteLine($"Display: {bundle1.Display()}");
            Console.WriteLine($"Price: {bundle1.CalculatePrice()}");

        }
    }
}
