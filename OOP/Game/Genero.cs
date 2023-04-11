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
        private string genre;
        private int minAge;

        public Genero(string genre, int minAge)
        {
            this.genre = genre;
            this.minAge = minAge;
        }

        static public int SelectGenre(List<Genero> genres)
        {
            for (int i = 0; i < genres.Count; i++)
                Console.WriteLine($"{i}: {genres.ElementAt(i)}");
            int option = Functions.ReadInt("Elige genero", 0, genres.Count - 1);
            return option;
        }

        public string Genre { get => genre; }
        public int MinAge { get => minAge; }

        public override string ToString() => $"Genero: {genre} Edad(min): {minAge}";

    }
}
