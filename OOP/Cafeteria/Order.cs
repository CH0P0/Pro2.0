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

        Product Product { get; set; }
        string Time { get; set; }

        public Order(Product Product)
        {
            this.Product = Product;
            Time = GetDate();
        }

        public string GetDate()
        {
            DateTime actualDate = DateTime.Now;
            return actualDate.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public string GetTime() => Time;

        public override string ToString() => $"producto: {Product}\tfecha-hora:{GetTime()}";
    }
}
