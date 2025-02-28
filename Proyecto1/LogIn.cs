using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class LogIn : Form
    {
        private User user;
        public LogIn()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //location 133, 97
            // size 414, 270
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            logInInformation information = new logInInformation();
            information.Visible = true;
        }

        internal void loadUserInfo(User user)
        {
            colorsCB.Visible = false;
            int age = DateTime.Now.Year - user.Birthday.Year;
            this.user = user;
            this.BackColor = Color.FromArgb(63, 150, 253);
            ageLbl.Visible = addressLbl1.Visible = ageLbl1.Visible = emailLbl1.Visible = logOutBtn.Visible =
            userPB.Visible = PrivilagesLbl.Visible = addressLbl.Visible = emailLbl.Visible = nameLbl.Visible = true;
            logInBtn.Visible = false;
            nameLbl.Text = user.FullName;
            PrivilagesLbl.Text = user.Privileges.ToString();
            emailLbl.Text = user.Email;
            addressLbl.Text = user.Address;

            if (user.Birthday > DateTime.Now.AddYears(-age))
            {
                age--;
            }
            ageLbl.Text = (age).ToString();

            if (isAdmin(user))
            {
                colorsCB.Visible = true;
            }

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.user = null;
            this.Hide();
            
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.Visible = false;
                }
            }
            this.BackColor = Color.FromArgb(255, 255, 255);
            logInBtn.Visible = true;
            colorsCB.Visible = userPB.Visible = logOutBtn.Visible = false;
            Task.Delay(5000);
            this.Show();
        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private bool isAdmin(User user)
        {
            return user.Privileges == Privileges.Administrator;
        }

        private void changeColor()
        {
            if (colorsCB.Text == "Red")
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label label)
                    {
                        label.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void colorsCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (colorsCB.Text == "Red")
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label label)
                    {
                        label.ForeColor = Color.Red;
                    }
                }
            }
            else if (colorsCB.Text == "Green") 
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label label)
                    {
                        label.ForeColor = Color.Green;
                    }
                }
            }
            else if (colorsCB.Text == "Pink")
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label label)
                    {
                        label.ForeColor = Color.Pink;
                    }
                }
            }
            else if (colorsCB.Text == "Black")
            {
                foreach (Control control in this.Controls)
                {
                    
                    if (control is Label label)
                    {
                        label.ForeColor = Color.Black;
                    }

                }

            }

        }

    }

}