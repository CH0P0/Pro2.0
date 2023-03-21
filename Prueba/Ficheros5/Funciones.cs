using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros5
{
    internal class Funciones
    {
        public static int IndexOf(string search, string[] line)
        {
            for (int i = 0; i < line.Length; i++)
                if (line[i] == search)
                    return i;
            return -1;
        } 
    }
}
