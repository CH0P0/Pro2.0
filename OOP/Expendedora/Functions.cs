using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    internal class Functions
    {
        public static void ShowOptions()
        {
            Console.WriteLine($"\nElije una opción\n" +
                $"1.- Añadir Producto a la máquina\n" +
                $"2.- Eliminar Producto de la máquina\n" +
                $"3.- Comprar Producto\n" +
                $"4.- Rellenar máquina\n" +
                $"5.- Mostrar Contenido Máquina\n" +
                $"0.- Salir");
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
