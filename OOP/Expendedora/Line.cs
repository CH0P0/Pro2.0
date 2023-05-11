using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    internal class Line
    {
        private Product Product { get; set; }
        
        private int Stock { get; set; }

        public Line(Product product, int stock)
        {
            this.Product = product;
            this.Stock = stock;
        }

        public Product GetProduct() => Product;

        public void SetProduct(Product product) => this.Product = product;

        public int GetStock() => Stock;

        public void SetStock() => this.Stock = Stock;
    }
}
