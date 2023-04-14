using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP._5
{
    internal class Ficheros
    {
        public const string FILENAME = "clientes.csv";

        public static bool Exist() => File.Exists(FILENAME);

        public static bool MakeFile(bool oveRide = true)
        {
            try
            {
                bool make = false;
                if (Exist())
                    if (oveRide)
                    {
                        Console.Write("\n\n\tEl archivo ya existe. \n\t\t¿Desea sobrescribirlo? S/N");
                        if (Console.ReadKey().Key == ConsoleKey.S)
                            make = true;
                    }
                else 
                        make = true;
                if (make)
                {
                    File.Create(FILENAME).Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        } 

        public static bool SaveData(ClientList<Client> clientList)
        {
            try
            {
                MakeFile(false);
                StreamWriter sw = new StreamWriter(FILENAME);
                clientList.ForEach(client =>
                {
                    sw.WriteLine($"{client.Name};{client.Surname};{client.CodClient}");
                });
                sw.Close();
                return true;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static ClientList<Client> TakeData()
        {
            ClientList<Client> clients = new();
            List<string> lines = File.ReadAllLines(FILENAME).ToList();
            lines.ForEach(line =>
            {
                string[] data = line.Split(';');
                Client c = new Client(data[0], data[1], Convert.ToInt32(data[2]));
                clients.Add(c);
            });
            return clients;
        }
    }
}
