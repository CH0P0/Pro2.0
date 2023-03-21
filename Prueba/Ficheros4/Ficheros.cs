using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros4
{
    internal class Ficheros
    {
        public const string FILE1 = "texto1.txt", FILE2 = "texto2.txt", OUTFILE = "salida.txt";
        static List<string> lines1 = new(), lines2 = new();

        public static bool FileExist() => File.Exists(FILE1) && File.Exists(FILE2);

        public static bool MakeFile()
        {
            bool valor = true;
            StreamWriter sw = null;

            try
            {
                sw = File.CreateText(OUTFILE);
                sw.Close();
                Console.Clear();
                Console.WriteLine("Fichero creado vacío");
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }

            return valor;
        }

        public static bool ReadFile()
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(OUTFILE);
                lines1 = File.ReadAllLines(FILE1).ToList();
                lines2 = File.ReadAllLines(FILE2).ToList();
                int max = lines1.Count > lines2.Count ? lines1.Count : lines2.Count;

                for (int i = 0; i < max; i++)
                {
                    if (i < lines1.Count)
                        sw.WriteLine(lines1[i]);
                    if (i < lines2.Count)
                        sw.WriteLine(lines2[i]);
                }
                sw.Close();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
