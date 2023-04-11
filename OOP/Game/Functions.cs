using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Functions
    {
        public static int Menu()
        {
            int value;
            Console.WriteLine("\n\t1: Añadir juego.\n\t" +
            "2: Mostrar juegos\n\t" +
            "3: Eliminar juego\n\t0:Cerrar Programa");
            value = ReadInt("Introduzca una opción", 0, 3);
            return value;
        }

        public static int ReadInt(string msg, int? min = null, int? max = null)
        {
            int num;

            do
                Console.WriteLine(msg);
            while (!Int32.TryParse(Console.ReadLine(), out num) || num < min || num > max);
            return num;
        }

        public static string ReadString(string msg, int? min = null, int? max = null)
        {
            string text;
            do
            {
                Console.WriteLine(msg);
                text = Console.ReadLine() ?? "";

            } while (text.Trim() == "");
            return text;
        }
        public static decimal ReadDecimal(string msg, int? min = null, int? max = null)
        {
            decimal num;

            do
                Console.WriteLine(msg);
            while (!Decimal.TryParse(Console.ReadLine(), out num) || num < min || num > max);
            return num;
        }

    }
}
