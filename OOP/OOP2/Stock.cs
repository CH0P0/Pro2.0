using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Stock<T> : List<T>
    {
        public static List<string> products = new()
        {
            "Fanta", "Coca-Cola", "Agua", "Salmón",
            "Albahaca", "Anillo", "Tenaza", "Guantes",
            "Cable VGA", "Limón", "Pomelo", "Piedra",
            "Sandwich", "Mortadela", "Coco", "Gafas de sol"
        };

        
        public string GetProduct(int j) => products[j];

        public static void GetProducts()
        {
            Console.WriteLine("\n\tLista de clientes: ");
            var query = products.Select((c, indice) => new { indice, producto = c });
            foreach (var elem in query)
                Console.WriteLine("\n\t" + elem);
        }

        public static void FillUp(Stock<Product> stock)
        {
            foreach (Product p in stock)
                p.Fill();
        }
    }
}
