using System.Diagnostics;

namespace OOP
{
        /*(1) Queremos informatizar una lista de clientes, de los que queremos saber 
         * el nombre y sus apellidos, que no deben ser nulos.A cada cliente, le asignaremos 
         * un número que irá correlativo. Generaremos un menú que nos permita crear 
         * un cliente, buscar si un cliente pertenece a la lista, mostrar los clientes 
         * de la lista y eliminar un cliente de la lista.*/
    class Program
    {
        static void Main(string[] args)
        {
/*          ClientList<Client> clientList = new ClientList<Client>();
            clientList.AddClient(new Client("Juan", "Antonio", 1));
            clientList.AddClient(new Client("Rafael", "Eduardo", 2));
            clientList.AddClient(new Client("Andres", "Josafat", 3));
            clientList.AddClient(new Client("Eduardo", "Manuel", 4));
            Funciones.SearchTest(clientList, "Andres", "Josafat");*/
            Funciones.Menu();
        }
    }
}