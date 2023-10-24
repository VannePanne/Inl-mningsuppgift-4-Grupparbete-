namespace Inlämningsuppgift_4__Grupparbete_
{
    public partial class Form1 : Form
    {
        private List<Food> originalFoods;

        public Form1()
        {
            InitializeComponent();
            originalFoods = Food.LoadFoodsFromFile("Foods.txt");
            LoadFoodsIntoDataGridView(originalFoods); //f
        }

        private void LoadFoodsIntoDataGridView(List<Food> foods) //f
        {
            // Bind the list of foods to the DataGridView
            dataGridView1.DataSource = foods;
            // Display only the name in the DataGridView
            dataGridView1.Columns["Recipe"].Visible = false;
            dataGridView1.Columns["FoodType"].Visible = false;
        }
        

        private void btnSearch_Click(object sender, EventArgs e) //f
        {
            string searchTerm = txtSearch.Text.ToLower();
            List<Food> foods = (List<Food>)dataGridView1.DataSource;

            // Filter foods based on search term from the original list
            var searchResults = foods.Where(food => food.Name.ToLower().Contains(searchTerm)).ToList();

            // Update the DataGridView with search results
            LoadFoodsIntoDataGridView(searchResults);
        }
    }


}