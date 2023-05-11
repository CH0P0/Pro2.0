using System.Reflection.PortableExecutable;

namespace Expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Machine machine = new Machine();
            int option;
            do
            {
                Functions.ShowOptions();
                option = Functions.ReadInt("Introduce una opción", 0, 5);
                switch (option)
                {
                    case 1:
                        break;
                }
            } while (option != 0);
        }
    }
}