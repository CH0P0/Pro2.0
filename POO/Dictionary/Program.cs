namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dictionary<string, int> edades = new();

            edades.Add("Juan", 26);

            edades["Maria"] = 25;
            edades["Antonio"] = 32;

            foreach(KeyValuePair<string, int> persona in edades)
                Console.WriteLine($"Nombre: {persona.Key} - Edad: {persona.Value}");
        }
    }
}