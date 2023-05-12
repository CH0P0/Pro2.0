using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_OOP
{
    internal class Game
    {
        private string Nombre { get; set; }

        private decimal Precio { get; set; }

        private bool Alquilado { get; set; }

        List<User> Alquilados { get; set; }

        // Constructores
        public Game() { }

        public Game(string nombre, decimal precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Alquilado = false;
            this.Alquilados = new List<User>();
        }

        // Getter y Setters

        public string GetNombre() => this.Nombre;

        public void SetNombre(string nombre) => this.Nombre = nombre;

        public decimal GetPrecio() => this.Precio;

        public void SetPrecio(decimal precio) => this.Precio = precio;

        public bool GetAlquilado() => this.Alquilado;

        public void SetAlquilado(bool alquilado) => this.Alquilado = alquilado;

        public List<User> GetAlquilados() => this.Alquilados;

        public void SetAlquilados(List<User> alquilados) => this.Alquilados = alquilados;

        public override string ToString() => $"Juego: {this.Nombre} - Precio {this.Precio}";
    }
}
