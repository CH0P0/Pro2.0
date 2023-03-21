using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._5
{
    internal class Client
    {
        private string name, surname;
        private int codClient;

        public Client(string name, string surname, int codClient)
        {
            this.name = name;
            this.surname = surname;
            this.codClient = codClient;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Trim() != "")
                    name = value;
            }
        }

        public string Surname
        {
            get => surname; set
            {
                if (value.Trim() != "")
                    surname = value;
            }
        }

        public int CodClient { get => codClient; }

        public override string ToString() => $"Nombre: {Name}\tApellido: {Surname}\tCodCliente: {CodClient}";
    }
}
