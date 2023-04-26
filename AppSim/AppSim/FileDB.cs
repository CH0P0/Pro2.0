using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSim
{
    internal class FileDB
    {
        public const string FILENAME = "userDatabase.csv";

        public static bool Exist() => File.Exists(FILENAME);

        public static bool MakeFile()
        {
            try
            {
                if (!Exist())
                    File.Create(FILENAME).Close();
                Console.WriteLine("Archivo creado con exito");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
