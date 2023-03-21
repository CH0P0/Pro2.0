namespace DelegadoPredicado
{
    internal class Program
    {
        // Definicion del objeto delegado
        delegate void Objeto();

        static void Main(string[] args)
        {
            // Creacion del objeto delegado apuntando a Welcome
            Objeto Delegado = new Objeto(WelcomeMSG.Welcome);
            Delegado();

            Delegado = new Objeto(GoodbyeMSG.GoodBye);
            Delegado();

            // predicado
            List<int> numbs = new();
            numbs.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Predicate<int> predicado = new Predicate<int>(OddEven);
            List<int> evenList = numbs.FindAll(predicado);
            evenList.ForEach(delegate (int numb)
            {
                Console.WriteLine(numb);
            });

            // poco mas complicado
            List<Personas> people = new();
            Personas p1 = new();
            p1.Age = 19;
            p1.Name = "Juan";
            Personas p2 = new();
            p2.Age = 22;
            p2.Name = "Maria";
            Personas p3 = new();
            p3.Age = 15;
            p3.Name = "Juana";

            people.AddRange(new Personas[] { p1, p2, p3 });

            Predicate<Personas> predication = new Predicate<Personas>(JuanExist);
            bool exist = people.Exists(predication);
            Console.WriteLine(exist);
        }

        static bool OddEven(int num) => num % 2 == 0;

        static bool JuanExist(Personas persona) => persona.Name == "Juan";
    }

    // DELEGADO

    class WelcomeMSG
    {
        public static void Welcome()
        {
            Console.WriteLine("Hola acabo de llegar");
        }
    }

    class GoodbyeMSG
    {
        public static void GoodBye()
        {
            Console.WriteLine("Adios");
        }
    }

    // PREDICADO

    class Personas
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}