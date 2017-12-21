using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ItemCollection();
            collection.Add(new ContainableItem("Coca Cola",3,"Drinks","330",1,1,1));
            collection.Add(new ContainableItem("Chips", 6.5, "Snacks", "food", 1, 2, 2));
            collection.Add(new ContainableItem("Bounty", 3.5, "Sweets", "food", 1, 3, 1));

            string deleteproduct= "Coca Cola";
            collection.Remove(deleteproduct);

            Console.WriteLine("Vending machine contains: " + collection.Count() + " kind of products");
            
            Console.WriteLine(collection.ToString());
         
            Console.ReadLine();
        }
    }
}
