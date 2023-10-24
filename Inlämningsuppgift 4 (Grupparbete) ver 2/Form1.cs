namespace Inlämningsuppgift_4__Grupparbete_
{
    public partial class Form1 : Form
    {
        private const string RecipeFilePath = "recipes.txt";
        private const string AdminFilePath = "admin.txt";
        private List<Recipe> RecipeList = new List<Recipe>();
        private List<Admin> AdminList = new List<Admin>();

        public Form1()
        {
            InitializeComponent();
            LoadRecipes();
            LoadAdmins();

        }

        // Loads the .txt file and puts its content in a list and the dataGridView
        private void LoadRecipes()
        {

            if (!File.Exists(RecipeFilePath))
            {
                // Create a new empty ".txt" file
                File.Create(RecipeFilePath).Close();
            }


            using (StreamReader reader = new StreamReader(RecipeFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        RecipeList.Add(new Recipe { Title = parts[0], Description = parts[1], Type = parts[2] });
                        recipeDataGridView.Rows.Add(parts[0]);
                    }
                }
            }

        }

        // Loads the .txt file and puts its content in a list
        private void LoadAdmins()
        {
            if (!File.Exists(AdminFilePath))
            {
                // Create a new empty ".txt" file
                File.Create(AdminFilePath).Close();
            }


            using (StreamReader reader = new StreamReader(AdminFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        AdminList.Add(new Admin { Username = parts[0], Password = parts[1] });
                        recipeDataGridView.Rows.Add(parts[0]);
                    }
                }
            }
        }

        // Remove everything from the dataGridView method
        private void ResetDataGridView()
        {
            recipeDataGridView.Rows.Clear();
        }


        // Search for recipes method
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                ResetDataGridView();
                LoadRecipes();
            }
            else
            {
                ResetDataGridView();

                foreach (var recipe in RecipeList)
                {
                    if (txtSearch.Text.ToLower().Contains(recipe.Title.ToLower())) // Maybe should write it the other way around aka txtSearch.Text.ToLower().Contains(recipe.Title.ToLower())
                    {
                        recipeDataGridView.Rows.Add(recipe.Title);
                    }
                }
            }
        }

        // Open a new Form that displays the Title and the description if I select a row.
        private void recipeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (recipeDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = recipeDataGridView.SelectedRows[0];

                string selectedTitle = selectedRow.Cells[0].Value.ToString();

                Recipe selectedRecipe = RecipeList.FirstOrDefault(recipe => recipe.Title == selectedTitle);

                // If the selectedRecipe doesn't return null
                if (selectedRecipe != null)
                {
                    RecipeDetailsForm detailsForm = new RecipeDetailsForm(selectedRecipe);
                    detailsForm.ShowDialog();
                }

            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show();
        }

        //private bool AdminSignedIn()
        //{


        //    return;
        //}
    }
}