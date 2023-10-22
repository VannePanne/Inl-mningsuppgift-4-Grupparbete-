using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace recp_18_ok
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Logg_Click(object sender, EventArgs e)
        {
            const string correctEmail = "najah";
            const string correctPassword = "123";
            if (Userbox.Text == correctEmail && passbox.Text == correctPassword)
            {
                MessageBox.Show("Du är inloggad");
                //Uppgift 3
                admin admin = new admin();
                admin.ShowDialog();

            }
        }
    }
}
