using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros1
{
    internal class Ficheros
    {
        public const string FICHENTRADA = "input.txt", FICHSALIDA = "output.txt";


        public static bool IniciarFichero() => File.Exists(FICHENTRADA);

        public static bool CrearFichero()
        {
            bool valor = true;
            StreamWriter sw = null;

            try
            {
                sw = File.CreateText(FICHSALIDA);
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

        public static bool EscribirFichero()
        {
            bool valor = true, error = false;
            StreamWriter sw = null;
            StreamReader sr = null;

            try
            {
                sw = new StreamWriter(FICHSALIDA, true);
                sr = new StreamReader(FICHENTRADA);
                string[] linea;
                Console.Clear();
                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine().Split(';');
                    error = Funciones.ValidarSize(linea);
                    if (error && Funciones.ValidarNum(linea))
                    {
                        sw.WriteLine($"{linea[0]}+{linea[1]}={Convert.ToInt32(linea[0]) + Convert.ToInt32(linea[1])}");
                    }
                    else
                    {
                        Console.WriteLine($"{(error == true ? "Los números son invalidos" : "El tamaño es invalido")}");
                    }
                }
                sw.Close();
                sr.Close();
                Process.Start("notepad.exe", FICHSALIDA);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }

            return valor;
        }
    }
}
