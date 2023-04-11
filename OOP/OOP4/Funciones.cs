using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Funciones
    {
        private static Basket<Product[]> basket = new Basket<Product[]> { };
        private static Product[] buyProducts = new Product[0];
        public static void Menu()
        {
            Console.WriteLine("Maquina expendedora");
            bool value = true;
            do
            {
                for (int i = 0; i < Basket<string>.products.Count; i++)
                {
                    if (i % 4 == 0)
                        Console.WriteLine();
                    Console.Write($"{i}: {Basket<string>.products.ElementAt(i)}$\t\t");
                }
                Console.WriteLine($"\n\n\tSeleccione una opcion:\n\t1: Comprar producto.\n\t" +
                $"0: Salir");
                int option = ReadInt("Seleccione una opcion:", 0, 1);
                switch (option)
                {
                    case 1:  BuyProducts();break;
                    default: value = false; break;  
                }
                Console.ReadKey();
                Console.Clear();
            } while (value);
            if (buyProducts.Length > 0)
                basket.Add(buyProducts);
        }

        public static void ShowPrice()
        {
            int min, indexMin = 4, sumPrices = 0;
            for (int i = 0; i < basket.Count; i++)
            {
                min = basket[i][0].Price;
                if (basket[i].Length == 3)
                    for (int k = 0; k < basket[i].Length; k++)
                    {
                        if (min > basket[i][k].Price)
                        {
                            min = basket[i][k].Price;
                            indexMin = k;
                        }
                    }
                for (int j = 0; j < basket[i].Length; j++)
                {
                    Console.WriteLine($"Producto\tPrecio\tPrecio aplicado\n" +
                        $"{basket[i][j].Name}\t{basket[i][j].Price}\t{(j == indexMin && basket[i].Length == 3 ? 0 : basket[i][j].Price)}");
                    if (!(j == indexMin))
                        sumPrices += basket[i][j].Price;
                }
                min = 0; indexMin = 4;
            }
            Console.WriteLine($"Precio final: {sumPrices}");
        }

        public static void BuyProducts()
        {
            int selection = ReadInt("Seleccione el indice de un producto", 0, Basket<string>.products.Count - 1);
            string productName = Basket<string>.products[selection].Split(' ')[0];
            int price = Convert.ToInt32(Basket<string>.products[selection].Split(' ')[1]);

            if (buyProducts.Length == 3)
            {
                basket.Add(buyProducts);
                buyProducts = new Product[0];
            }
            Array.Resize(ref buyProducts, buyProducts.Length + 1);
            buyProducts[^1] = new Product(productName, price);
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
