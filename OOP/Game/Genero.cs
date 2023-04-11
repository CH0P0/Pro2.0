using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game
{
    internal class Genero
    {
        private static string genre;

        public static List<string> genres = new()
        {
            "accion", "ciencia ficcion", "fantasia",
            "terror", "rpg", "aventuras", "plataformas",
            "mmorpg"
        };

        public void SelectGenre()
        {
            for (int i = 0; i < genres.Count; i++)
            {
                if (i % 4 == 0)
                    Console.WriteLine();
                Console.Write($"{i}: {genres.ElementAt(i)}\t\t");
            }
            int option = Functions.ReadInt("Elige genero", 0, genres.Count);
            genre = genres.ElementAt(option);
        }
        public override string ToString() => $"Genero: {genre}";

    }
}
