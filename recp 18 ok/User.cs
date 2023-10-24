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
    public partial class User : Form
    {
        test test = new test();
        admin admin = new admin();
        show show = new show();
        public User()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {

            List<test> receptbok = test.showData();
            dataGridView1.Rows.Clear();
            comboBox1.Items.Clear();
            foreach (var recept in receptbok)
            {
                dataGridView1.Rows.Add(recept.Titel, recept.Katagory, recept.Portion, recept.Ingredienser, recept.Hur);
                if (!comboBox1.Items.Contains(recept.Katagory))
                {
                    comboBox1.Items.Add(recept.Katagory);

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem as string;

            if (selectedCategory != null)
            {
                List<test> filteredReceptbok = test.showData().Where(recept => recept.Katagory == selectedCategory).ToList();
                dataGridView1.Rows.Clear();

                foreach (var recept in filteredReceptbok)
                {
                    dataGridView1.Rows.Add(recept.Titel, recept.Katagory, recept.Portion, recept.Ingredienser, recept.Hur);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower(); // Convert search text to lowercase for case-insensitive search

            List<test> receptbok = test.showData();
            dataGridView1.Rows.Clear();

            foreach (var recept in receptbok)
            {
                if (recept.Titel.ToLower().Contains(searchText) ||
                    recept.Katagory.ToLower().Contains(searchText) ||
                    recept.Portion.ToLower().Contains(searchText) ||
                    recept.Ingredienser.ToLower().Contains(searchText) ||
                    recept.Hur.ToLower().Contains(searchText))
                {
                    dataGridView1.Rows.Add(recept.Titel, recept.Katagory, recept.Portion, recept.Ingredienser, recept.Hur);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string title = dataGridView1.SelectedCells[0].Value.ToString();
            string category = dataGridView1.SelectedCells[1].Value.ToString();
            string portion = dataGridView1.SelectedCells[2].Value.ToString();
            string ingredients = dataGridView1.SelectedCells[3].Value.ToString();
            string howTo = dataGridView1.SelectedCells[4].Value.ToString();

            // Assuming 'userForm' is an instance of the 'user' form
            show.SetData(title, category, portion, ingredients, howTo);

            // Show the 'user' form
            show.ShowDialog();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Show();
        }

        private void User_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
            GetData();
        }
    }
}
