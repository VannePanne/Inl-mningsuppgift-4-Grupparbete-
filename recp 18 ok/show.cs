using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recp_18_ok
{
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }

        public void SetData(string title, string category, string portion, string ingredients, string howTo)
        {
            lbltitel.Text = title;
            lblkat.Text = category;
            lblportion.Text = portion;
            lbling.Text = ingredients;
            lblhur.Text = howTo;
        }

        private void show_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
