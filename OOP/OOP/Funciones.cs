/*(1) Queremos informatizar una lista de clientes, de los que queremos saber 
        * el nombre y sus apellidos, que no deben ser nulos.A cada cliente, le asignaremos 
        * un número que irá correlativo. Generaremos un menú que nos permita crear 
        * un cliente, buscar si un cliente pertenece a la lista, mostrar los clientes 
        * de la lista y eliminar un cliente de la lista.*/

using System.Runtime.CompilerServices;

namespace OOP
{
    public class Funciones
    {
        static int codClient = 1;
        static ClientList<Client> clientList = new ClientList<Client>();

        public static void Menu()
        {
            int value;
            const string MSGNAME = "Introduce nombre cliente", MSGSURNAME = "Introduce apellidos cliente";
            Client client = new Client(ReadString(MSGNAME, 0),
                ReadString(MSGSURNAME, 0), codClient++);
            clientList.AddClient(client);
            do
            {
                Console.WriteLine("\n\t1: Crear cliente.\n\t" +
                    "2: Buscar si un cliente pertenece a la lista\n\t3: Mostrar la lista\n\t" +
                    "4: Eliminar un cliente de la lista\n\t" +
                    "0:Eliminar un cliente de la lista");
                value = ReadInt("Introduzca una opción", 0, 4);
                switch (value)
                {
                    case 1:
                        client = new Client(ReadString(MSGNAME, 0), ReadString(MSGSURNAME, 0), codClient++);
                        clientList.AddClient(client); break;
                    case 2: Search(); break;
                    case 3: ClientList<Client>.SelectClient(); break;
                    case 4: 
                        clientList.DeleteClient(ReadInt("Seleccione el indice de un cliente", 0, clientList.Count - 1));
                        break;
                    default: break;
                }

            } while (value != 0);


        }

        public static void Search()
        {
            Console.WriteLine("Introduce el nombre y apellidos de la persona que quieras buscar");
            string name = ReadString("No puede ser vacío", 0),
                   surname = ReadString("No puede ser vacío", 0);
            Predicate<Client> clientFinder = (Client p) => { return (p.Name == name) && (p.Surname == surname); };
            Predicate<Client> clientExist = (Client c) => { return c.Name != "null" && c.Surname != "null"; };
            Client client = clientList.Find(clientFinder) ?? new Client("null", "null", 0);
            if (clientExist(client))
                Console.WriteLine("El cliente pertenece a la lista");
            else
                Console.WriteLine("El cliente no pertenece a la lista");
        }

        public static string SearchTest(ClientList<Client> clientLi, string name_, string surname_)
        {
            string name = name_, surname = surname_;
            Predicate<Client> clientFinder = (Client p) => { return (p.Name == name) && (p.Surname == surname); };
            Predicate<Client> clientExist = (Client c) => { return c.Name != "null" && c.Surname != "null"; };
            Client client = clientLi.Find(clientFinder) ?? new Client("null", "null", 0);
            if (clientExist(client))
              return "El cliente pertenece a la lista";
            else
              return"El cliente no pertenece a la lista";
        }

        public static string ReadString(string msg, int? min = null, int? max = null)
        {
            string text;
            do
            {
                Console.WriteLine(msg);
                text = Console.ReadLine() ?? "";

            } while (text.Trim() == "");
            return text;
        }

        public static int ReadInt(string msg, int? min = null, int? max = null)
        {
            int num;

            do
                Console.WriteLine(msg);
            while (!Int32.TryParse(Console.ReadLine(), out num) || num < min || num > max);
            return num;
        }
    }
}
