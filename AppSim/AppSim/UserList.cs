using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSim
{
    internal class UserList<User> : List<User>
    {
        public static void ShowUsers(UserList<User> users)
        {
            Console.WriteLine("\n\tLista de usuarios: ");
            users.ForEach(user =>
            {
                Console.WriteLine($"\n\t{user}");
            });
        }
    }
}
