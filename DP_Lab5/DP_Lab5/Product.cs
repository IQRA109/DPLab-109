using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Lab5
{
    public class Product : iProductComponent
    {
        private string name {  get; set; }
        private string description { get; set; }
        private double price { get; set; }

        public Product(string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }
        public double CalculatePrice()
        {
            return price;
        }
        public string Display()
        {
            return $"Product: {name}, Price: {price}, Description: {description}";
        }
    }
}
