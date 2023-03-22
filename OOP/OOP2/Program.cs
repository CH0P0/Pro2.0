
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock<Product> stock = new Stock<Product>();
            for (int i = 0; i < Stock<string>.products.Count; i++)
            {
                stock.Add(new Product(Stock<string>.products[i]));
            }
            stock[1].Less();
            var query = stock.Select(c => c.ToString());
            foreach (var item in query)
                Console.WriteLine(" " + item);
            Stock<Product>.FillUp(stock);
            foreach (var item in query)
                Console.WriteLine(" " + item);

        }

        public static int ReadInt(string msg, int? min = null, int? max = null)
        {
            int num;

            do
                Console.WriteLine(msg);
            while (!Int32.TryParse(Console.ReadLine(), out num) || num < min || num > max);
            return num;
        }
    }
}