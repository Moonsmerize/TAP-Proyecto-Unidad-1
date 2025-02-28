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
        bool hidePass = true;
        public logInInformation()
        {
            InitializeComponent();
        }

        private void logInInformation_Load(object sender, EventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            incorrectLbl.Visible = emailMissingLbl1.Visible = emailMissingLbl.Visible = false;

            if (emailTB.Text == "" || passwordTB.Text == "")
            {
                if (emailTB.Text == "") emailMissingLbl.Visible = true;
                if (passwordTB.Text == "") emailMissingLbl1.Visible = true;
            }
            else
            {

                foreach (User user in UsersRepository.users)
                {
                    if (emailTB.Text == user.Email && passwordTB.Text == user.Password)
                    {
                        LogIn login = Application.OpenForms["LogIn"] as LogIn;
                        login.loadUserInfo(user);
                        this.Close();
                    }
                    else
                    {
                        incorrectLbl.Visible = true;
                    }
                }

            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Visible = true;
        }

        private void fgtYourPasswordBtn_Click(object sender, EventArgs e)
        {
            RecoverPassword recover = new RecoverPassword();
            recover.Visible = true;
        }

        private void frgPasswordOn(object sender, EventArgs e)
        {
            fgtYourPasswordBtn.Font = new Font(fgtYourPasswordBtn.Font, FontStyle.Bold);
        }

        private void frgPasswordOff(object sender, EventArgs e)
        {
            fgtYourPasswordBtn.Font = new Font(fgtYourPasswordBtn.Font, FontStyle.Regular);
        }

        private void hidePassBtn_Click(object sender, EventArgs e)
        {
            hidePass = !hidePass;
            if (hidePass == false)
            {
                passwordTB.PasswordChar = '*';
            }
            else
            {
                passwordTB.PasswordChar = '\0';
            }
        }

        private void hidePassBtn_MouseEnter(object sender, EventArgs e)
        {
            hidePassBtn.BackColor = Color.Gray;
        }

        private void hidePassBtn_MouseLeave(object sender, EventArgs e)
        {
            hidePassBtn.BackColor = Color.White;
        }
    }
}
