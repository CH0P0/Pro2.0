using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSim
{
    class UserList<T> : List<T>
    {
        /// <summary>
        /// Muestra en pantalla todos los usuarios.
        /// Solo permitido para administradores
        /// </summary>
        /// <param name="users">Lista a mostrar</param>
        public static void ShowUsers(UserList<User> users)
        {
            Console.WriteLine("\n\tLista de usuarios: ");
            users.ForEach(user =>
            {
                Console.WriteLine($"\n\t{user}");
            });
        }

        /// <summary>
        /// Método que busca si ya existe un nombre de usuario
        /// </summary>
        /// <param name="users">Lista de usuarios</param>
        /// <param name="username">Nombre a buscar en la lista</param>
        /// <returns>Valor booleano que dice si existe o no</returns>
        public static bool SearchUserName(UserList<User> users, string username)
        {
            Predicate<User> userFinder = (User user) => user.GetName() == username;
            return users.Exists(userFinder);
        }

        /// <summary>
        /// Método que busca si ya existe un email de usuario
        /// </summary>
        /// <param name="users">Lista de usuarios</param>
        /// <param name="email">Email a buscar en la lista</param>
        /// <returns>Valor booleano que dice si existe o no</returns>
        public static bool SearchEmail(UserList<User> users, string email)
        {
            Predicate<User> emailFinder = (User user) => user.GetEmail() == email;
            return users.Exists(emailFinder);
        }

        /// <summary>
        /// Método para encontrar el indice usuario logeado en la lista
        /// </summary>
        /// <param name="users">Lista de usuarios</param>
        /// <param name="username">Nombre a buscar</param>
        /// <param name="password">Contraseña a buscar</param>
        /// <returns>retorna el indice del usuario, si no es correcto se devolvera -1</returns>
        public static int UserLogin(UserList<User> users, string username, string password)
        {
            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                if (user.GetName() == username && user.GetPassword() == password)
                    return i; 
            }
            return -1;
        }
    }
}
