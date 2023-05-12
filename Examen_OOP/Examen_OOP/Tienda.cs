using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen_OOP
{
    internal class Tienda
    {
        private string NombreEncargado { get; set; }

        private string TelefonoFijo { get; set; }

        private List<Game> Catalogo { get; set; }

        private List<User> Usuarios { get; set; }

        // Constructores
        public Tienda() { }

        public Tienda(string nombreEncargado, string telefonoFijo, List<Game> catalogo)
        {
            this.NombreEncargado = nombreEncargado;
            this.TelefonoFijo = telefonoFijo;
            this.Catalogo = catalogo;
            this.Usuarios = new();
        }

        // Getter y Setters
        public string GetNombreEncargado() => this.NombreEncargado;

        public void SetNombreEncargado(string nombreEncargado) => this.NombreEncargado = nombreEncargado;

        public string GetTelefonoFijo() => this.TelefonoFijo;

        public void SetTelefonoFijo(string telefonoFijo) => this.TelefonoFijo = telefonoFijo;

        public List<Game> GetCatalogo() => this.Catalogo;

        public void SetCatalogo(List<Game> catalogo) => this.Catalogo = catalogo;

        public List<User> GetUsuarios() => this.Usuarios;

        public void SetUsuarios(List<User> usuarios) => this.Usuarios = usuarios;

        // Métodos estaticos de la tienda

        public static string ValidarNombreEncargado()
        {
            string nombre;
            do
            {
                Console.WriteLine("Introduce el nombre del encargado(Mínimo 3 carácteres)");
                nombre = Console.ReadLine() ?? "";

            } while (nombre.Trim().Length < 3);
            return nombre;
        }

        public static string ValidarNumTelefono()
        {
            string numTel = "922",
                   cadena;
            bool esValido = false;
            int num;
            Console.Write("Completa el número: 922");
            
            while(!esValido)
            {
                do
                {
                    cadena = Console.ReadLine();
                } while (cadena?.Trim().Length != 6);
                if (int.TryParse(cadena, out num) && num >= 0)
                {
                    esValido = true;
                    numTel += cadena;
                }
            }
            return numTel;
        }

        public static List<Game> CrearCatalogo()
        {
            List<Game> catalogo = new List<Game>();
            catalogo.Add(new Game("Zelda", 35.7m));
            catalogo.Add(new Game("Mario", 30m));
            catalogo.Add(new Game("Sonic", 27.4m));
            catalogo.Add(new Game("Alex Kid", 15.2m));
            catalogo.Add(new Game("Wonder Boy", 21.9m));

            return catalogo;
        }

        /// <summary>
        /// Realiza una serie de procesos para alquilar un juego de la tienda
        /// </summary>
        /// <param name="tienda">La tienda en la que se realizara el alquiler</param>
        public static void AlquilarJuego(Tienda tienda)
        {
            User user = User.UserValido();
            bool alquilar = true;
            int indiceUsuario = tienda.ExisteUsuario(user);

            if (indiceUsuario != -1)
            {
                if (tienda.GetUsuarios().ElementAt(indiceUsuario).GetAlquilado() == true)
                {
                    Console.WriteLine("Actualmente tienes un juego alquilado");
                    alquilar = false;
                }
            }
            else
            {
                tienda.GetUsuarios().Add(user);
            }
            // Si el usuario ya tiene un juego alquilado no se alquilará
            if (alquilar)
            {
                Console.WriteLine("Seleccione un juego a alquilar:");
                Tienda.EnseñarCatalogoDisponible(tienda, user);
            }
        }

        public static void EnseñarCatalogo(Tienda tienda)
        {
            int i = 1;
            tienda.GetCatalogo().ForEach(juego =>
            {
                Console.WriteLine($"{i++}: {juego}");
            });
        }

        public static void EnseñarCatalogoDisponible(Tienda tienda, User user)
        {
            int i = 1;
            List<Game> juegosDisponibles = tienda.GetCatalogo().FindAll(juego => juego.GetAlquilado() == false);
            juegosDisponibles.ForEach(juego =>
            {
                if (juego.GetAlquilado() == false)
                {
                    Console.WriteLine($"{i}: {juego}");
                    i++;
                }
            });

            int indiceJuego = Funciones.ReadInt($"Introduce un número del 1 al {i}", 1, i);
            Game alquilado = juegosDisponibles.ElementAt(indiceJuego - 1);
            tienda.GetCatalogo().ForEach(game =>
            {
                if (game.GetNombre() == alquilado.GetNombre())
                {
                    game.SetAlquilado(true);
                    game.GetAlquilados().Add(user);
                    int indiceUsuario = tienda.GetUsuarios().IndexOf(user);
                    tienda.GetUsuarios().ElementAt(indiceUsuario).SetAlquilado(true);
                    tienda.GetUsuarios().ElementAt(indiceUsuario).SetJuegoAlquilado(game);
                }
            });
        }

        public static void EnseñarOpciones()
        {
            Console.WriteLine($"\nElije una de las siguientes opciones:\n" +
                $"1.- Alquilar juego\n" +
                $"2.- Devolver juego\n" +
                $"3.- Mostrar info tienda\n" +
                $"4.- Mostrar historial\n" +
                $"0.- Salir");
        }

        public static void EnseñarInfoTienda(Tienda tienda)
        {
            Console.WriteLine(tienda);
        }

        public static void MostrarHistorial(Tienda tienda)
        {
            string textoHistorial;
            Console.WriteLine("Seleccione el juego del que desea mostrar el historial: ");
            Tienda.EnseñarCatalogo(tienda);
            int opcion = Funciones.ReadInt("Introduce un número del 1 al 5", 1, 5);
            Game juegoSelectionado = tienda.GetCatalogo().ElementAt(opcion - 1);
            textoHistorial = juegoSelectionado.ToString() + " usuarios: ";
            juegoSelectionado.GetAlquilados().ForEach(usuario =>
            {
                textoHistorial += $"{usuario.GetCodUser()} - ";
            });
            textoHistorial += $"\nTotal recaudado: {juegoSelectionado.GetAlquilados().Count * juegoSelectionado.GetPrecio()}";
            Console.WriteLine(textoHistorial);
        }

        public static void DevolverJuego(Tienda tienda)
        {
            User user = User.UserValido();
            int indiceUsuario = tienda.ExisteUsuario(user);
            if (indiceUsuario == -1)
            {
                Console.WriteLine("No existe ningún usuario con ese codigo.");
                return;
            }
            if (tienda.GetUsuarios().ElementAt(indiceUsuario).GetAlquilado() == true)
            {
                Game? juegoAlquilado = tienda.GetUsuarios().ElementAt(indiceUsuario).GetJuegoAlquilado();
                Console.WriteLine("El juego alquilado es: ");
                Console.WriteLine(juegoAlquilado);
                tienda.GetUsuarios().ElementAt(indiceUsuario).SetAlquilado(false);
                tienda.GetUsuarios().ElementAt(indiceUsuario).SetJuegoAlquilado(null);
                tienda.GetCatalogo().ForEach(juego =>
                {
                    if (juego.GetNombre() == juegoAlquilado.GetNombre())
                        juego.SetAlquilado(false);
                });


            } else
            {
                Console.WriteLine("No tiene ningún juego alquilado");
            }
        }

        // Métodos no estaticos
        public int ExisteUsuario(User usuario)
        {
            int indice = -1,
                i = 0;

            this.GetUsuarios().ForEach(user =>
            {
                if (user.GetCodUser() == usuario.GetCodUser())
                    indice = i;
                i++;
            });
            return indice;
        }

        public override string ToString()
        {
            string texto = $"Encargado de la tienda: {this.NombreEncargado}\n" +
                $"Telefono de tienda: {this.TelefonoFijo}\n\n" +
                $"Juegos disponibles: \n";
            this.Catalogo.ForEach(juego =>
            {
                if (juego.GetAlquilado() == false)
                    texto += $"{juego}\n";
            });
            texto += "\nJuegos alquilados: \n";
            this.Catalogo.ForEach(juego =>
            {
                if (juego.GetAlquilado() == true)
                    texto += $"{juego} -- Usuario que lo tiene: {juego.GetAlquilados().ElementAt(^1).GetCodUser()}\n";

            });

            return texto;
        }
    }
}
