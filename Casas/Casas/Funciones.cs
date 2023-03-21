namespace Casas
{
    class Funciones
    {
        // Método que sirve para leer y validar numeros enteros incluyendo rangos.
        public static int LeerEntero(string msg, int? min = null, int? max = null)
        {
            int num;

            do
                Console.WriteLine(msg);
            while (!Int32.TryParse(Console.ReadLine(), out num) || num < min || num > max);
            return num;
        }

        // Método que sirve para Leer los datos de los nombres
        // de las casas y sus costos
        public static void LeerDatos(string[] casas, double[] costos)
        {
            for (int i = 0; i < casas.Length; i++)
            {
                string cadena;
                Console.Write($"Introduce el nombre de la casa [{i}](Sin repetirla): ");
                do
                    cadena = Console.ReadLine() ?? "";
                while (casas.Contains(cadena));
                casas[i] = cadena;
                // Si le pasas una cadena vacía el nombre por defecto será Casa generica y un indice
                if (casas[i] == "")
                    casas[i] = "Casa genérica " + i;
                Console.WriteLine($"Introduce el costo de {casas[i]}:");
                costos[i] = Math.Round(LeerDouble("El costo debe ser un número positivo", 0), 2);
            }
        }

        // Método para establecer tanto el limite superior como inferior.
        public static double Limite(double? inf = null, bool superior = false) =>
            LeerDouble($"Introduce el límite {(superior == true ? "superior" : "inferior")}.", inf);

        // Método que lee y válida un double
        private static double LeerDouble(string msg, double? min = null)
        {
            double num;

            do
                Console.WriteLine(msg);
            while (!Double.TryParse(Console.ReadLine(), out num) || num <= min);
            return num;
        }

        // Método para localizar y retornar las casas dentro de los limites
        public static string[] CasasEnRango(string[] casas, double[] costos, double limInf, double limSup)
        {
            string[] listado = new string[0] ;
            for (int i = 0; i < casas.Length; i++)
            {
                if (costos[i] <= limSup && costos[i] >= limInf)
                {
                    Array.Resize(ref listado, listado.Length + 1);
                    listado[^1] = casas[i];
                }
            }
            return listado;
        }

        public static void MostrarListado(string[] listado)
        {
            foreach(var elem in listado)
                Console.WriteLine(elem);
        }

        // Este método sirve para imprimir los indices y casas que existen y seleccionar una.
        public static int SelecCasa(string[] casas)
        {
            Console.WriteLine("Selecciona el indice de una de las casas");
            var query = casas.Select((c, indice) => new { indice, casa = casas.GetValue(indice) });
            foreach (var elem in query)
                Console.WriteLine(elem);
            return LeerEntero("La elección debe estar dentro del índice", 0, casas.Length);
        }

        public static int NumCasasCosteInf(double costeMax, double[] costes)
        {
            int numCasasCosteInf = 0;

            foreach(double elem in costes)
                if (elem < costeMax)
                    numCasasCosteInf++;
            return numCasasCosteInf;
        }
    }
}
