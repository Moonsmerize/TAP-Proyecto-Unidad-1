using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Validators
    {

        public static bool emailValidator(string email) {
            return email.Contains(".") && email.Contains("@");
        }

        public static bool isAdult(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int edad = today.Year - birthday.Year;
          
            if (birthday.Month > today.Month ||
                (birthday.Month == today.Month && birthday.Day > today.Day))
            {
                edad--;
            }

            return edad >= 18;
        }




    }
}