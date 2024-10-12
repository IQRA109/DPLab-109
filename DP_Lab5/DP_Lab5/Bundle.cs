using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Lab5
{
    public class Bundle : iProductComponent
    {
        private string name { get; set; }
        private string description { get; set; }
        private double discount { get; set; }
        public List<iProductComponent> ProductComponents = new List<iProductComponent>();
       

        public Bundle(string name, string description, double discount )
        {
            this.name = name;
            this.description = description; 
            this.discount = discount;
        }
        public void Add(iProductComponent component)
        {
            ProductComponents.Add(component);
        }

        public void Remove(iProductComponent component)
        {

            ProductComponents.Remove(component);
        }

        public double CalculatePrice()
        {
            double totalPrice = ProductComponents.Sum(Product => Product.CalculatePrice());
            return totalPrice*(1-discount);
        }

        public string Display()
        {
            string details = $"Bundle: {name}, Description: {description}";

            foreach (iProductComponent component in ProductComponents)
            {
                details += component.Display();
            }
            return details;

        }

    }
}
