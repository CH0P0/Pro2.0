using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Product
    {
        int stock = 10;
        string product;

        public Product(string product)
        {
            this.product = product;
        }

        public override string ToString() => $"producto: {product}, stock: {stock}";

        public void Less()
        {
            if (stock != 0)
                stock--;
            else
                Console.WriteLine("No queda stock del producto");
        }

        public void Fill() => stock = 10;
    }
}
