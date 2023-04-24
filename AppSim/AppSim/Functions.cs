using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSim
{
    internal class Functions
    {
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
    }
}
