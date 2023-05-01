using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSim
{
    internal class FileDB
    {
        public const string FILENAME = "userDatabase.csv";

        public static bool Exist() => File.Exists(FILENAME);

        /// <summary>
        /// Método que crea la base de datos si esta no existe
        /// </summary>
        /// <returns>
        /// Valor booleano que muestra si ha sucedido algún error  
        /// </returns>
        public static bool MakeFile()
        {
            try
            {
                File.Create(FILENAME).Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Método cuya finalidad es la de guardar en un archivo csv
        /// los datos recogidos en cada lanzamiento del programa
        /// </summary>
        /// <param name="users">Usuarios a guardar en la base de datos</param>
        /// <returns>
        /// Valor booleano que muestra si ha sucedido algún error  
        /// </returns>
        public static bool SaveData(UserList<User> users)
        {
            try
            {
                MakeFile();
                StreamWriter sw = new StreamWriter(FILENAME);
                Random rnd = new();
                users.ForEach(user =>
                {
                    user.Cipher(rnd.Next(1,25));
                    sw.WriteLine($"{user.GetCodUser()};{user.GetName()}" +
                        $"{user.GetEmail()};{user.GetIsAdmin()};{user.GetPassword()}");
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

        /// <summary>
        /// Método que lee los datos del fichero simulando
        /// una base de datos
        /// </summary>
        /// <returns>Los usuarios registrados en la aplicación</returns>
        public static UserList<User> ReadData()
        {
            UserList<User> users = new();
            List<string> lines = File.ReadAllLines(FILENAME).ToList();
            string lastLine = lines[^1];
            User.cod = Convert.ToInt32(lastLine.Split(';')[0]);
            lines.ForEach(line =>
            {
                string[] data = line.Split(';');
                User u = new User(Convert.ToInt32(data[0]), data[1], data[^1], data[2], Convert.ToBoolean(data[3]));
                users.Add(u);
            });
            return users;
        }
    }
}
