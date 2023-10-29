using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECEPT4DUMMIES
{
    public partial class FormLogIn : Form
    {
        private List<Admin> admins;
        public bool IsLoginSuccessful;



        public FormLogIn(List<Admin> admins)
        {
            InitializeComponent();

            this.admins = admins;
        }

        private bool SignIn()
        {
            string username = UsernameTextbox.Text.ToLower();
            string password = PasswordTextbox.Text;

            foreach (var admin in admins)
            {
                if (username == admin.Username.ToLower() && password == admin.Password)
                {
                    return true;
                }
            }
            return false;
        }


        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (SignIn())
            {
                IsLoginSuccessful = true;
                this.Close();
            }
            else
            {
                IsLoginSuccessful = false;
                MessageBox.Show("fel namn och eller lösenord.");
            }
        }
    }
}
