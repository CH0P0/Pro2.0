namespace Ficheros1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Ficheros.IniciarFichero())
            {
                Ficheros.CrearFichero();
                Ficheros.EscribirFichero();

            } 
            else
            {
                Console.WriteLine("El fichero no existe");
            }
        }
    }
}