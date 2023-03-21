using System;
using System.Collections.Generic;
/*(1) Queremos informatizar una lista de clientes, de los que queremos saber 
        * el nombre y sus apellidos, que no deben ser nulos.A cada cliente, le asignaremos 
        * un número que irá correlativo. Generaremos un menú que nos permita crear 
        * un cliente, buscar si un cliente pertenece a la lista, mostrar los clientes 
        * de la lista y eliminar un cliente de la lista.*/

namespace OOP
{
    public class ClientList<T> : List<T>
    {
        static public List<T> clientData;

        public ClientList() => clientData = new ();

        public void AddClient(T item) => clientData.Add(item);

        public void DeleteClient(int i) => clientData.RemoveAt(i);

        public T GetClient(int j) => clientData[j];

        public static void SelectClient()
        {
            Console.WriteLine("\n\tLista de clientes: ");
            var query = clientData.Select((c, indice) => new { indice, cliente = clientData[indice].ToString() });
            foreach (var elem in query)
                Console.WriteLine("\n\t" + elem);
        }
    }
}
