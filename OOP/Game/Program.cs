using System.ComponentModel.Design;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            List<Game> library = new();
            Game game;
            Genero genre = new();
            library.Add(new Game());
            do
            {
                option = Functions.Menu();
                switch (option)
                {
                    case 1: genre.SelectGenre() ; game = new Game(Functions.ReadString("Introduce el nombre del juego"),
                        genre,
                        Functions.ReadDecimal("Introduce el precio",0))
                            ;break;
                    case 2: 
                        library.ForEach(game =>
                        {
                            Console.WriteLine(game);
                        }); break;
                }
            } while (option != 0);
        }
    }
}