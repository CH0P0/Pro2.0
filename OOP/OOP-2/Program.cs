namespace OOP_2
{
    internal class Program
    {
        public static readonly string[] products = new string[] { "Agua", "Cerveza", "Pizza de limón", "Albahaca", "Huevos"};
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] stock = new int[] { 10, 10, 10, 10, 10 };
            SpendMachinez<string, int[]> machine = new ();
            for (int i = 0; i < products.Length; i++)
                machine.Add(products[i], stock);
            SpendMachinez<string, int[]>.ShowStock(machine);
        }
    }
}