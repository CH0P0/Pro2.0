using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Stock
    {
        static int[] stock = new int[] { 10, 10, 10, 10, 10 };

        public static void ReduceStock(int line)
        {
            if (stock[line] == 0)
            {
                Console.WriteLine("No queda más producto en esta linea");
            }
        }
    }
}
