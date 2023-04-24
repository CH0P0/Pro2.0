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

        public Genero Genre
        {
            get
            {
                return genre;
            }
        }


        public decimal Price 
        { 
            get => price; 
            set {
                if (value >= 0)
                    price = value;
                else
                    price = 0;
            } 
        }

        public override string ToString() => $"Nombre: {Name}\t{Genre}\tPrecio: {Price}";

    }
}
