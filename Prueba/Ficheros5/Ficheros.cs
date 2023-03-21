using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros5
{
    internal class Ficheros
    {
        public const string FILENAME = "Turismo.csv";
        public static List<string> lines = new();
        static int indexOfYear, indexOfCountry, index4S, index5S, numbOfCountries;
        public static readonly string[] month = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

        public static bool FileExist() => File.Exists(FILENAME);

        public static bool ReadFile()
        {
            try
            {
                int[] values = new int[4];
                lines = File.ReadAllLines(FILENAME).ToList();
                values[0] = indexOfYear = 0;//Funciones.IndexOf("año", lines[0].Split(';'));
                values[1] = indexOfCountry = Funciones.IndexOf("nacion", lines[0].Split(';'));
                values[2] = index4S = Funciones.IndexOf("4 estrellas", lines[0].Split(';'));
                values[3] = index5S = Funciones.IndexOf("5 estrellas", lines[0].Split(';'));
                return values.Contains(-1) ? false : true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static void ShowCountries()
        {
            Console.WriteLine("Elige el país o agrupación a seleccionar:\n");
            int cont = 1;
            string currentCountry = "";
            while (currentCountry != "TOTAL")
            {
                currentCountry = lines[cont].Split(";")[indexOfCountry];
                if (currentCountry != "TOTAL")
                    Console.WriteLine($"{cont}. {currentCountry}");
                else
                    numbOfCountries = cont;

                cont++;
            }
        } 


        public static int SelectYear()
        {
            int selection;
            for (int i = 1; i < lines.Count; i += (numbOfCountries + 1) * 12 - 1)
            {
                Console.WriteLine(lines[i].Split(';')[indexOfYear]);
            }
            return 1;
        }

        public static void ShowInfo()
        {
            int count1 = 1, count2 = 1;
            while (lines[count1].Split(';')[indexOfYear] != "2016") { count1++; }
            while (lines[count2].Split(';')[indexOfCountry] != "Holanda") { count2++; }
            Console.WriteLine($"PAIS: {lines[count2].Split(';')[indexOfCountry]}");
            Console.WriteLine($"ANIO: {lines[count1].Split(';')[indexOfYear]}");
            for (int i = 1; i <= 12; i++)
            {
                string[] line = lines[(count1 + count2 - 1) + (numbOfCountries * (i - 1))].Split(';');  
                Console.WriteLine($"Mes: {month[i - 1]}" +
                    $"\t\t\t4 estrellas: {line[index4S]}" +
                    $"\t\t\t5 estrellas: {line[index5S]}");
            }
        }
    }
}
