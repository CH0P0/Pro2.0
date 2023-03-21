using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class SpendMachinez<T,T2> : Dictionary<string, int[]>
    {
        public static void ShowStock(SpendMachinez<string, int[]> productStock)
        {
            Console.WriteLine("\n\tLista de clientes: ");
            var query = productStock.Select((c, indice) => new { indice, V = c.Value[indice] });
            foreach (var elem in query)
                Console.WriteLine("\n\t" + elem);
        }
    }
}
