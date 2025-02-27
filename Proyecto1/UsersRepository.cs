using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class UsersRepository
    {
        public static List<User> users = new List<User>();

        public static List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public static void addUser(User usuario)
        {
            users.Add(usuario);
        }


    }
}
