namespace Casas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] casas = new string[Funciones.LeerEntero("Introduce un número de casas entero entre 10 y 30", 5, 30)];
            double[] costos = new double[casas.Length];

            Funciones.LeerDatos(casas, costos);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            double limInf = Math.Round(Funciones.Limite(), 2),
                   limSup = Math.Round(Funciones.Limite(limInf, true));

            Console.WriteLine("Las casas son: ");
            Funciones.MostrarListado(casas);
            string[] listadoCasasRango = Funciones.CasasEnRango(casas, costos, limInf, limSup);

            Console.WriteLine("\n\nLas casas dentro del rango seleccionado son: ");
            Funciones.MostrarListado(listadoCasasRango);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            double costoCasaSelect = costos[Funciones.SelecCasa(casas)];
            int numCasasCosteInf = Funciones.NumCasasCosteInf(costoCasaSelect, costos);

            Console.WriteLine($"El número de casas con precio inferior a {costoCasaSelect} es {numCasasCosteInf}");
            Console.WriteLine("Presione una tecla para terminar el programa...");
            Console.ReadKey();
        }
    }
}