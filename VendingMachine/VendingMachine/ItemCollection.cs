using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ItemCollection
    {
        private List<ContainableItem> itemCollectionList = new List<ContainableItem>();
        public void Add(ContainableItem containableItem)
        {
            itemCollectionList.Add(containableItem);
        }

        public void Remove(string product)
        {
            itemCollectionList.Remove(GetItem(product));
        }

        public int Count()
        {
            return itemCollectionList.Count();
        }

        public ContainableItem GetItem(string product)
        {
            foreach (ContainableItem Item in itemCollectionList)
            {
                if (Item.Product.Name == product) return Item;
                else return null;
            }
            return null;
        }
        public string AllProductList()
        {
            string buffer="";
            foreach (ContainableItem Item in itemCollectionList)
            {
                buffer += Item.ToString();
            }
            return buffer;
        }
    }
}
