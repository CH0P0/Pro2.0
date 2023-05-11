using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    internal class Product
    {
        private string ProductName { get; set; }
        private decimal Price { get; set; }

        public Product(string ProductName, decimal Price)
        {
            this.ProductName = ProductName;
            this.Price = Price;
        }

        public string GetProductName() => ProductName;

        public void SetProductName(string ProductName) => this.ProductName = ProductName; 

        public decimal GetPrice() => Price;

        public void SetPrice(decimal Price) => this.Price = Price;
    }
}
