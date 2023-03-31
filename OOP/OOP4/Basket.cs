using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Basket<T> : List<T>
    {
        public static List<string> products = new()
        {
            "Fanta 2", "Coca-Cola 2", "Agua 1", "Salmón 5",
            "Albahaca 3", "Anillo 3", "Tenaza 6", "Guantes 4",
            "Cable-VGA 7", "Limón 1", "Pomelo 2", "Piedra 10",
            "Sandwich 4", "Mortadela 2", "Coco 8", "Gafas de sol 22"
        };
    }
}
