using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_OOP
{
    internal class Funciones
    {
        public static int ReadInt(string msg, int? min = null, int? max = null)
        {
            int num;

            while (!Int32.TryParse(Console.ReadLine(), out num) || num < min || num > max)
                Console.WriteLine(msg);
            return num;
        }
    }
}
