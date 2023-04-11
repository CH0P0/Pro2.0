using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._5
{
    internal class ClientList<T> : List<T>
    {
        public static void SelectClient(ClientList<Client> clientData)
        {
            Console.WriteLine("\n\tLista de clientes: ");
            var query = clientData.Select((c, indice) => new { indice, cliente = clientData.ToString() });
            foreach (var elem in query)
                Console.WriteLine("\n\t" + elem);
        }
    }
}
