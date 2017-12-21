using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
   
    public class Product
    {
        private string name;
        private double price;
        private ProductCategory category;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public ProductCategory Category { get => category; set => category = value; }
       

        public Product (string name, double price, string categoryName, string description)
        {
            this.name = name;
            this.price = price;
            category = new ProductCategory(categoryName, description);
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
            this.category = new ProductCategory();
        }
        public Product()
        {

        }
     
    }
}
