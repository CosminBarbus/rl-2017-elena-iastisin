using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ContainableItem
    {
        public int Row { get; }
        public int Column { get; }
        public int Size { get; }
        public Product Product{ get;}


        public ContainableItem(Product product, int row,int column, int size)
        {
            Row = row;
            Column = column;
            Size = size;
            Product = product;
        }
        public ContainableItem()
        {

        }

        public override string ToString()
        {
            return Product.ToString() + "\nRow: " + Row + "\nColumn: " + Column + "\nSize" + Size;
        }
    }
}
