using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class logInInformation : Form
    {
        public logInInformation()
        {
            InitializeComponent();
        }

        private void logInInformation_Load(object sender, EventArgs e)
        {
           
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            User logged = new User();
            if (emailTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                foreach (User user in UsersRepository.users)
                {
                    if (emailTB.Text == user.Email && passwordTB.Text == user.Password) 
                    {
                        MessageBox.Show("sesion iniciada");
                        logged = user;
                    }
                }
                
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Visible = true;
        }
    }
}
