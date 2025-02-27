using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Seeder
    {

        public static void Initialize() {

            UsersRepository.addUser(new User("Nestor Daniel Luna Avila","luan991019@gmail.com","Por ahi",new DateTime(1999,10,19),Privileges.administrator,"1234"));
            UsersRepository.addUser(new User("EHC","EHC@gmail.com","Por alla",new DateTime(2005,9,3),Privileges.user,"5678"));
            foreach (User user in UsersRepository.users)
            {
                MessageBox.Show("Nombre: " + user.FullName);
            }
        }

    }
}
