/*(1) Queremos informatizar una lista de clientes, de los que queremos saber 
        * el nombre y sus apellidos, que no deben ser nulos.A cada cliente, le asignaremos 
        * un número que irá correlativo. Generaremos un menú que nos permita crear 
        * un cliente, buscar si un cliente pertenece a la lista, mostrar los clientes 
        * de la lista y eliminar un cliente de la lista.*/

namespace OOP
{
    public class Client
    {
        private string name, surname;
        private int codClient;

        public Client(string name, string surname, int codClient)
        {
            this.name = name;
            this.surname = surname;
            this.codClient = codClient;
        }
        
        public string Name {
            get => name;
            set {
                if (value.Trim() != "")
                    name = value;
            }
        }

        public string Surname { 
            get => surname; set
            {
                if (value.Trim() != "")
                    surname = value;
            } 
        }

        public int CodClient { get => codClient;}

        public override string ToString() => $"Nombre: {Name}\tApellido: {Surname}\tCodCliente: {CodClient}";
    }
}
