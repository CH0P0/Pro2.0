using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Funciones
    {
        static Stock<Product> stock = new Stock<Product>();

        public static void Menu()
        {
            for (int i = 0; i < Stock<string>.products.Count; i++)
                stock.Add(new Product(Stock<string>.products[i]));

            int option;

            do
            {
                Console.WriteLine("Maquina expendedora");
                for (int i = 0; i < stock.Count; i++)
                {
                    if (i % 4 == 0)
                        Console.WriteLine();
                    Console.Write($"{i}: {stock.ElementAt(i).GetProduct}\t\t");
                }
                Console.WriteLine($"\n\n\tSeleccione una opcion:\n\t1: Comprar producto.\n\t" +
                    $"2: Rellenar la máquina\n\t3: ver stock\n\t" +
                    $"0: Salir");
                option = ReadInt("Seleccione una opción: ", 0, 3);
                switch (option)
                {
                    case 1: Buy(); break;
                    case 2: Stock<Product>.FillUp(stock); break;
                    case 3: ShowStock(); break;
                    default: break;

                }
                Console.ReadKey();
                Console.Clear();
            } while (option != 0);
        }

        public static void ShowStock()
        {
            var query = stock.Select(c => c.ToString());
            foreach (var item in query)
                Console.WriteLine(" " + item);

        }

        public static void Buy()
        {
            Console.WriteLine("Teclee el número del producto que desee comprar");
            int selection = ReadInt("Introduzca un valor válido", 0, stock.Count - 1);
            stock.ElementAt(selection).SubsStock();
            Console.WriteLine($"Ha comprado: {stock.ElementAt(selection).GetProduct}");
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
