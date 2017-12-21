using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ProductCategory
    {
        private string categoryName;
        private string description;

        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }

        public ProductCategory()
        {
            this.categoryName = "No category";
            this.description = "No description";
        }
        public ProductCategory(string categoryName, string description)
        {
            this.categoryName = categoryName;
            this.description = description;
        }
        public override string ToString()
        {
            return categoryName + "\nDescription: " + description;
        }
    }
}
