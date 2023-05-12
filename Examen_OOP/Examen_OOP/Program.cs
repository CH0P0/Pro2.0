namespace Examen_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = Tienda.ValidarNombreEncargado();
            string numTel = Tienda.ValidarNumTelefono();
            List<Game> catalogo = Tienda.CrearCatalogo();
            Tienda tienda = new Tienda(nombre, numTel, catalogo);
            int option;

            do
            {
                Tienda.EnseñarOpciones();
                option = Funciones.ReadInt("Introduce una opción entre el 0 y el 4", 0, 4);

                switch (option)
                {
                    case 1:
                        Tienda.AlquilarJuego(tienda);
                        break;
                    case 2:
                        Tienda.DevolverJuego(tienda);
                        break;
                    case 3:
                        Tienda.EnseñarInfoTienda(tienda);
                        break;
                    case 4:
                        Tienda.MostrarHistorial(tienda);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (option != 0);



        }
    }
}