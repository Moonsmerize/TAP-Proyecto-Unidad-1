using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class User
    {

        private string fullName;
        private string email;
        private string address;
        private DateTime birthday;
        private Privileges privileges;
        private string password;

        public User() 
        {
            this.fullName = "";
            this.email = "";
            this.address = "";
            this.birthday = new DateTime(1,1,1);
            this.privileges = Privileges.User;
            this.password = "";
        }

        public User(string fullName, string email, string address, DateTime birthday, Privileges privileges, string password)
        {
            this.fullName = fullName;
            this.email = email;
            this.address = address;
            this.birthday = birthday;
            this.privileges = privileges;
            this.password = password;
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public Privileges Privileges
        {
            get { return privileges; }
            set { privileges = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
