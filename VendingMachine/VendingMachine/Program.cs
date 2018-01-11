using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine
{
    class Program
    {
        static void AddProduct(ItemCollection collection)
        {

            Console.WriteLine("Enter product name (name sould be unique): ");
            string name=Console.ReadLine();

            if (collection.GetItem(name) != null)
            if (collection.GetItem(name).Product.Name == name) { throw new Exception("Product exist"); }

            Console.WriteLine("Enter product price: ");
            double price = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter product category: ");
            string categoryName = Console.ReadLine();

            Console.WriteLine("Enter product description: ");
            string description = Console.ReadLine();

            Product product = new Product(name, price, categoryName, description);
            Console.WriteLine("Enter product Row location: ");

            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Column location: ");

            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Size occupied (1-5): ");

            int size = int.Parse(Console.ReadLine());
            ContainableItem item = new ContainableItem(product,row, column, size);

            collection.Add(item);
        }


        static void Main(string[] args)
        {
            int option ;

            ItemCollection collection = new ItemCollection();
            do
            {
                Console.WriteLine("User Option:");
                Console.WriteLine("1: Add Product;");
                Console.WriteLine("2: Remove Product;");
                Console.WriteLine("3: Print All product List;");
                Console.WriteLine("9: Exit;");
                Console.WriteLine("Introduce your option");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddProduct(collection);
                        break;
                    case 2:
                        Console.Write("Name of the product to be removed: "); string name = Console.ReadLine();
                        collection.Remove(name);
                        break;
                    case 3:
                        Console.Write(collection.AllProductList());
                        break;
                    case 9:
                        break;
                    default: break;
                }
            } while (option != 9);
            
        }

    }
}
