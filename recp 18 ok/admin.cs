using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Drawing.Imaging;
using System.Text;

namespace recp_18_ok
{
    public partial class admin : Form
    {
        test test = new test();
        public admin()
        {
            InitializeComponent();
            GetData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string Titel = Titelbox.Text;
            string katagory = Katagorybox.Text;
            string Portion = portionbox.Text;
            string ingredienser = ingredienserbox.Text;
            string Hur = Hurbox.Text;
            test.Add(Titel, katagory, Portion, ingredienser, Hur);
            CLear();
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Titelbox.Text = dataGridView1.SelectedCells[0].Value.ToString();
            Katagorybox.Text = dataGridView1.SelectedCells[1].Value.ToString();
            portionbox.Text = dataGridView1.SelectedCells[2].Value.ToString();
            ingredienserbox.Text = dataGridView1.SelectedCells[3].Value.ToString();
            Hurbox.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        public void CLear()
        {
            dataGridView1.Rows.Clear();
            Titelbox.Clear();
            Katagorybox.Clear();
            portionbox.Clear();
            ingredienserbox.Clear();
            Hurbox.Clear();
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

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchbox.Text.ToLower(); // Convert search text to lowercase for case-insensitive search

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
        private void Delete_Click(object sender, EventArgs e)
        {
            string recepttodelete = Titelbox.Text;
            test.Delete(recepttodelete);
            CLear();
            GetData();
        }


        private void Update_Click(object sender, EventArgs e)
        {
           

        }
    }
}