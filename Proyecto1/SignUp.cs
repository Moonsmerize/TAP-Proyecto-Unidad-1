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
    public partial class SignUp : Form
    {
        private DateTime birthday;
        public SignUp()
        {
            InitializeComponent();
            dateMissingLbl.SendToBack();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            dateMissingLbl.Visible = nameMissingLbl.Visible = passwordMissingLbl.Visible = addressMissingLbl.Visible = emailMissingLbl.Visible = false;
            if (Validators.isAdult(birthday))
            {
                if (nameTB.Text == "" || emailTB.Text == "" || passwordTB.Text == "" ||
                    addressTB.Text == "" || dayCB.Text == "" || monthCB.Text == "" || yearCB.Text == "")
                {
                    emailMissingLbl.Text = "This field is invalid";
                    if (nameTB.Text == "") nameMissingLbl.Visible = true;
                    if (passwordTB.Text == "") passwordMissingLbl.Visible = true;
                    if (addressTB.Text == "") addressMissingLbl.Visible = true;
                    if (emailTB.Text == "") emailMissingLbl.Visible = true;
                    if (dayCB.Text == "") dateMissingLbl.Visible = true;
                }
                else
                {
                    if (Validators.emailValidator(emailTB.Text))
                    {
                        if (administratorCL.Checked)
                        {
                            User user = new User(nameTB.Text, emailTB.Text, addressTB.Text, birthday, Privileges.Administrator, passwordTB.Text);
                            UsersRepository.addUser(user);
                        } else {
                            User user = new User(nameTB.Text, emailTB.Text, addressTB.Text, birthday, Privileges.User, passwordTB.Text);                           
                            UsersRepository.addUser(user);
                        }
                        this.Hide();
                    }
                    else
                    {
                        emailMissingLbl.Text = "Not a valid email";
                        emailMissingLbl.Visible = true;
                    }
                }
            }
            else 
            {
                MessageBox.Show("You must be at least 18 years old");
            }
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void monthCB_MouseClick(object sender, MouseEventArgs e)
        {
            calendarC.Visible = true;
        }

        private void dayCB_MouseClick(object sender, MouseEventArgs e)
        {
            calendarC.Visible = true;
        }

        private void yearCB_MouseClick(object sender, MouseEventArgs e)
        {
            calendarC.Visible = true;
        }

        private void calendarC_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.birthday = calendarC.SelectionRange.Start;
            calendarC.Visible = false;
            dayCB.Text = birthday.Day.ToString();
            monthCB.Text = birthday.Month.ToString();
            yearCB.Text = birthday.Year.ToString();
        }
    }
}
