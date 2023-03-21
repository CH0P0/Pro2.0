namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce cuantos elementos desea tener el vector");
            int numbOfNumbs = ValidateNumb();
            List<int> ListaInt = new List<int> { };

            for (int i = 0; i < numbOfNumbs; i++)
                ListaInt.Add(ValidateNumb());

            Console.WriteLine(ListaInt.Count);

            foreach(int a in ListaInt)
                Console.WriteLine(a);
            ListaInt.Reverse();
            foreach (int a in ListaInt)
                Console.WriteLine(a);


        }

        public static int ValidateNumb()
        {
            int numb = 0;
            while (!Int32.TryParse(Console.ReadLine(), out numb))
                Console.WriteLine("Introduce un número entero válido");
            return numb;
        }
    }

}