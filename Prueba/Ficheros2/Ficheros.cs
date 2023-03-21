using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros2
{
    internal class Ficheros
    {
        public const string NOMBREFICH = "texto.txt";

        public static bool CrearFichero(bool sobreescribir = false)
        {
            try
            {
                bool crear = false;
                if (File.Exists(NOMBREFICH))
                {
                    if (sobreescribir)
                    {
                        Console.Write("\n\n\tEl archivo ya existe. \n\t\t¿Desea sobrescribirlo? S/N");
                        if (Console.ReadKey().Key == ConsoleKey.S)
                            crear = true;
                    }
                }
                else
                    crear = true;

                if (crear)
                {
                    File.Create(NOMBREFICH).Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool IntroducirNumeros()
        {
            bool valor = true;
            StreamWriter sw = null;
            int numbOfNumbs;

            try
            {
                sw = new StreamWriter(NOMBREFICH);
                Console.Write("Introduce el número de números que desaea meter: ");
                numbOfNumbs = Funciones.ValidateNumb();

                for (int i = 0; i < numbOfNumbs; i++)
                {
                    Console.WriteLine("Introduce un número");
                    sw.WriteLine(Funciones.ValidateNumb());
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }

            return valor;
        }

        public static bool MaxNumb()
        {
            bool valor = true;
            StreamReader sr = null;
            int max, currentNumb;

            try
            {
                sr = new StreamReader(NOMBREFICH);
                max = Convert.ToInt32(sr.ReadLine());

                while(!sr.EndOfStream)
                {
                    currentNumb = Convert.ToInt32(sr.ReadLine());
                    if (max < currentNumb)
                        max = currentNumb;
                }
                Console.WriteLine($"El valor máximo es {max}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }

            return valor;
        }

        public static bool MinNumb()
        {
            bool valor = true;
            StreamReader sr = null;
            int min, currentNumb;

            try
            {
                sr = new StreamReader(NOMBREFICH);
                min = Convert.ToInt32(sr.ReadLine());

                while (!sr.EndOfStream)
                {
                    currentNumb = Convert.ToInt32(sr.ReadLine());
                    if (min > currentNumb)
                        min = currentNumb;
                }
                Console.WriteLine($"El valor mínimo es {min}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }

            return valor;
        }

        public static bool Average()
        {
            try
            {
                List<int> lineas = File.ReadAllLines(NOMBREFICH).Select(int.Parse).ToList();
                Console.WriteLine($"La media es {lineas.Average()}");
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
