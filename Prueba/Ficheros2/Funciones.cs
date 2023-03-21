using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros2
{
    internal class Funciones
    {
        public static int ValidateNumb()
        {
            int numb;
            while (!Int32.TryParse(Console.ReadLine(), out numb))
                Console.WriteLine("Introduce un número entero válido");
            return numb;
        }
    }
}
