using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    internal class Order
    {
        static Dictionary<string, decimal> products = new Dictionary<string, decimal>()
        {
            { "sandwicht de pollo", 4 },
            { "tortilla con cebolla", 4 },
            { "zumo de naranja", 2 }

        };

        string Product { get; set; }
        decimal Price { get; set; }
        string Time { get; set; }

        public Order(string Product, decimal Price)
        {
            this.Product = Product;
            this.Price = Price;
            Time = GetDate();
        }

        public string GetDate()
        {
            DateTime actualDate = DateTime.Now;
            return actualDate.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static void ShowProducts()
        {
        }

    }
}
