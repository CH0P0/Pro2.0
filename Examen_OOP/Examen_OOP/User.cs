using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_OOP
{
    internal class User
    {
        private int CodUser { get; set; }
        
        private bool Alquilado { get; set; }

        private Game? JuegoAlquilado { set; get; }

        // Constructores
        public User() { }

        public User(int codUser)
        {
            this.CodUser = codUser;
            this.Alquilado = false;
            this.JuegoAlquilado = null;
        }

        // Getter y Setters
        public int GetCodUser() => this.CodUser;

        public void SetCodUser(int codUser) => this.CodUser = codUser;

        public bool GetAlquilado() => this.Alquilado;

        public void SetAlquilado(bool alquilado) => this.Alquilado = alquilado;

        public Game? GetJuegoAlquilado() => this.JuegoAlquilado;

        public void SetJuegoAlquilado(Game? juegoAlquilado) => this.JuegoAlquilado = juegoAlquilado;

        public static User UserValido()
        {
            int codUser = 0;
            Console.WriteLine("Introduce tu codigo de usuario(100-999)");
            while (!Int32.TryParse(Console.ReadLine(), out codUser) || codUser < 100 || codUser >= 1000)
                Console.WriteLine("Introduce tu codigo de usuario(100-999)");
            return new User(codUser);
        }
    }
}
