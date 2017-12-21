using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ItemCollection
    {
        private List<ContainableItem> ItemList = new List<ContainableItem>();
        public void Add(ContainableItem containableItem)
        {
            ItemList.Add(containableItem);
        }

        public void Remove(string product)
        {
            ItemList.Remove(GetItem(product));
        }

        public int Count()
        {
            return ItemList.Count();
        }

        public ContainableItem GetItem(string product)
        {
            foreach (ContainableItem Item in ItemList)
            {
                if (Item.Name == product) return Item;
                else return null;
            }
            return null;
        }

        public override string ToString()
        {
            string buffer = "";
            foreach (ContainableItem Item in ItemList)
            {
                buffer += "\nProduct Name: " + Item.Name + "\nPrice: " + Item.Price + "\nCategory: " + Item.Category.ToString() + "\nRow: "+ Item.Row + "\nColumn: "+ Item.Column+ "\n";
            }
            return buffer;
        }
    }
}
