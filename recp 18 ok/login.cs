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
        pass pass = new pass();

        public login()
        {
            InitializeComponent();
        }

        private void Logg_Click(object sender, EventArgs e)
        { 
            pass.managers.Add(new pass { username = "najah", password = "123" });
            pass.managers.Add(new pass { username = "Vanesa", password = "123" });
            pass.managers.Add(new pass { username = "Kamal", password = "123" });
            pass.managers.Add(new pass { username = "Simon", password = "123" });
            pass.managers.Add(new pass { username = "Kevin", password = "123" });
            pass.managers.Add(new pass { username = "Cornelia", password = "123" });
            
            string username = Userbox.Text.ToLower();
            string password = passbox.Text;

            if (pass.RightInloggning(username,password))
            {
                MessageBox.Show("Du är inloggad");
                // instanse of adminform
                admin admin = new admin();
                admin.ShowDialog();
            }
            else
                MessageBox.Show("Invalid username or password");
        }
    }
}
