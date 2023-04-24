using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._5
{
    internal class Funciones
    {
        static int codClient = 1;
        static ClientList<Client> clientList = new ClientList<Client>();

        public static void Menu()
        {
            int value;
            Client client;
            const string MSGNAME = "Introduce nombre cliente", MSGSURNAME = "Introduce apellidos cliente";
            if (Ficheros.Exist())
            {
                Console.Write("\n\n\tDesea usar los clientes de la base de datos? S/N");
                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    clientList = Ficheros.TakeData();
                    codClient = clientList[^1].CodClient;
                }
            }
            Console.Clear();
            if (clientList.Count == 0 )
            {
                client = new Client(ReadString(MSGNAME, 0),
                    ReadString(MSGSURNAME, 0), codClient++);
                clientList.Add(client);
            }
            do
            {
                Console.WriteLine("\n\t1: Crear cliente.\n\t" +
                    "2: Buscar si un cliente pertenece a la lista\n\t3: Mostrar la lista\n\t" +
                    "4: Eliminar un cliente de la lista\n\t" +
                    "0:Cerrar Programa");
                value = ReadInt("Introduzca una opción", 0, 4);
                switch (value)
                {
                    case 1:
                        client = new Client(ReadString(MSGNAME, 0), ReadString(MSGSURNAME, 0), codClient++);
                        clientList.Add(client); break;
                    case 2: Search(); break;
                    case 3: ClientList<Client>.SelectClient(clientList); break;
                    case 4:
                        clientList.RemoveAt(ReadInt("Seleccione el indice de un cliente", 0, clientList.Count - 1));
                        break;
                    default: break;
                }
                Console.ReadKey();
                Console.Clear();
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

        public static void Save() => Ficheros.SaveData(clientList);

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
