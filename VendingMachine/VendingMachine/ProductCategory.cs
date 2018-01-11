using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ProductCategory
    { 

        public string CategoryName { get; }
        public string Description { get; }

        public ProductCategory()
        {
            CategoryName = "No category";
            Description = "No description";
        }
        public ProductCategory(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
        }
        public override string ToString()
        {
            return "\nProduct Category : " + CategoryName + "\nDescription: " + Description;
        }
    }
}
