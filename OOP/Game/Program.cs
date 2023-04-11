using System.ComponentModel.Design;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> genres = new()
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
            int option;
            List<Game> library = new();
            Game game;
            Genero genre;
            library.Add(new Game());
            do
            {
                int genreSelection;
                option = Functions.Menu();
                switch (option)
                {
                    case 1: genreSelection = Genero.SelectGenre(genreList); genre = new Genero(genreList.ElementAt(genreSelection).Genre,
                        genreList.ElementAt(genreSelection).MinAge);
                        game = new Game(Functions.ReadString("Introduce el nombre del juego"),
                        genre, Functions.ReadDecimal("Introduce el precio",0));
                        library.Add(game); break;
                    case 2: 
                        library.ForEach(game =>
                        {
                            Console.WriteLine(game);
                        }); break;
                    case 3: library.RemoveAt(Functions.ReadInt("Introduce el indice del juego que quieras borrar", 0, library.Count - 1)); break;
                }
                
            } while (option != 0);
        }
    }
}