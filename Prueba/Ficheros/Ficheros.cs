using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros
{
    internal class Ficheros
    {
        public const string NOMBREFICH = "prueba.txt";

        public static bool IniciarFichero()
        {
            bool valor = true;
            StreamWriter sw = null;

            if (!File.Exists(NOMBREFICH))
                try
                {
                    sw = File.CreateText(NOMBREFICH);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    valor = false;
                }
            return valor;
        }

        public static bool CrearFichero()
        {
            bool valor = true;
            StreamWriter sw = null;

            try
            {
                sw = File.CreateText(NOMBREFICH);
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

        public static bool MostrarFichero()
        {
            bool valor = true;
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(NOMBREFICH);
                Console.Clear();
                Console.WriteLine("Contenido del fichero prueba.txt");
                Console.WriteLine("--------------------------------");
                while(!sr.EndOfStream)
                    Console.WriteLine(sr.ReadLine());
                sr.Close();
                Console.WriteLine("Pulse una tecla para continuar");
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
            bool valor = true;
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(NOMBREFICH, true);
                Console.Clear();
                Console.WriteLine("Introduzca la información a incluir en el fichero");
                Console.WriteLine("-------------------------------------------------");
                string cadena = Console.ReadLine();
                sw.WriteLine(cadena);
                sw.Close();
                Console.WriteLine("Información introducida");
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

        public static bool EliminarLinea()
        {
            bool valor = true;
            string[] lineas = new string[0];
            StreamReader sr = null;
            StreamWriter sw = null;

            try
            {
                sr = new StreamReader(NOMBREFICH);
                Console.Clear();
                string linea = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Array.Resize(ref lineas, lineas.Length - 1);
                    lineas[^1] = sr.ReadLine();
                }

                sr.Close();
                sw = File.CreateText(NOMBREFICH);

                foreach (string leida in lineas)
                    sw.WriteLine(leida);
                sw.Close();
                if (linea != null)
                    Console.WriteLine("Se ha eliminado la linea: " + linea);
                else
                    Console.WriteLine("No hay más lineas a eliminar");
                Console.WriteLine("Pulsa una tecla para continuar...");
                Console.ReadKey();
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
