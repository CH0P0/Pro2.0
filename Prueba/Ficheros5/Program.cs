namespace Ficheros5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Ficheros.FileExist();
            Ficheros.ReadFile();
            Ficheros.ShowCountries();
            Ficheros.SelectYear();
            Ficheros.ShowInfo();
        }
    }
}