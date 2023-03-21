using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros1
{
    internal class Funciones
    {

        public static bool ValidarSize(string[] linea) => linea.Length == 2;
        public static bool ValidarNum(string[] linea) => 
            Int32.TryParse(linea[0], out _) && Int32.TryParse(linea[1], out _);
    }
}
