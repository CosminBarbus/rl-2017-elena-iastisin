using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
   
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public ProductCategory Category { get; private set; }
       

        public Product (string productName, double productPrice, string categoryName, string description)
        {
            Name= productName;
            Price = productPrice;
            Category = new ProductCategory(categoryName, description);
        }

        public Product(string name, double price)
        {
            Name= name;
            Price = price;
            Category= new ProductCategory();
        }
        public Product()
        {

        }
        public override string ToString()
        {
            return "\nProduct Name: " + Name + "\nProduct Price: " + Price + Category.ToString();
        }

    }
}
