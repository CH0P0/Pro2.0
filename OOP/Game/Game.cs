using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Game
    {
        private string name;
        private Genero genre;
        private decimal price;
        public static List<string> genres = new()
        {
            "accion", "ciencia ficcion", "fantasia",
            "terror", "rpg", "aventuras", "plataformas",
            "mmorpg"
        };
        public Game()
        {
            name = "Nuevo Juego";
            price = 0;
        }

        public Game(string name, Genero genre, decimal price)
        {
            this.name = name;
            this.genre = genre;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }

        public string Genre { get => genre.ToString();}

        public decimal Price 
        { 
            get => price; 
            set {
                if (value >= 0)
                    price = value;
            } 
        }

        public override string ToString() => $"Nombre: {Name}\t{Genre}\tPrecio: {Price}";

        public static void ShowGenre()
        {
            for (int i = 0; i < genres.Count; i++)
            {
                if (i % 4 == 0)
                    Console.WriteLine();
                Console.Write($"{i}: {genres.ElementAt(i)}\t\t");
            }
        }

    }
}
