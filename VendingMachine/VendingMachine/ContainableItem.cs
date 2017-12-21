using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ContainableItem : Product
    {
        private int row;
        private int column;
        private int size;

        public ContainableItem(string name, double price, string categoryName, string description, int row, int column, int size) :
            base(name, price, categoryName, description)
        {
            this.row = row;
            this.column = column;
            this.size = size;
        }

        public ContainableItem()
        {
        }

        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public int Size { get => size; set => size = value; }
    }

}
