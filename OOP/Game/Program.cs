using System.ComponentModel.Design;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>? genres = new()
            {
                "accion,12", "ciencia ficcion,12", "fantasia,12",
                "terror,18", "rpg,16", "aventuras,12", "plataformas,8",
                "mmorpg,16"
            };
            List<Genero> genreList = new();
            genres.ForEach(elem =>
            {
                string[] data = elem.Split(',');
                genreList.Add(new Genero(data[0], int.Parse(data[1])));
            });
            genres = null;
            int option;
            List<Game> library = new();
            Game game;
            Genero genre;
            library.Add(new Game());
            do
            {
                option = Functions.Menu();
                switch (option)
                {
                    case 1: 
                        game = new Game(Functions.ReadString("Introduce el nombre del juego"),
                        genreList.ElementAt(Genero.SelectGenre(genreList)),
                        Functions.ReadDecimal("Introduce el precio",0));
                        library.Add(game); break;
                    case 2: 
                        library.ForEach(game =>
                        {
                            Console.WriteLine(game);
                        }); break;
                    case 3: 
                        library.RemoveAt(Functions.ReadInt("Introduce el indice del juego que quieras borrar", 0, library.Count - 1)); break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (option != 0);
        }
    }
}