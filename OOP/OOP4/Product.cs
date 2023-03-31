using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Product
    {
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price { 
            get { return price; } 
            set { price = value; }
        }
    }
}
