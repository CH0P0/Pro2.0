using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones3
{
    internal class Ficheros
    {
        public const string FILENAME = "datos.txt";
        static List<string> lines = new();

        public static bool FileExist() => File.Exists(FILENAME);


        public static bool ReadFile()
        {
            bool valor = true;
            StreamReader sr = null;
            bool fail = false;
            string[] data;
            try
            {
                sr = new StreamReader(FILENAME);
                lines = File.ReadAllLines(FILENAME).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    data = lines[i].Split(';');
                    fail = IsFail(data);
                    if (fail)
                    {
                        foreach(string line in data)
                            Console.Write(line + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }

            return valor;
        }

        public static bool IsFail(string[] data)
        {
            for (int i = 3; i < data.Length; i++)
            {
                if (!Int32.TryParse(data[i], out _))
                {
                    Console.WriteLine("Error eso no es un dato válido");
                    return false;
                }
                if (Convert.ToInt32(data[i]) >= 5)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
