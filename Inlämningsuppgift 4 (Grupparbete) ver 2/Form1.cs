namespace Inlämningsuppgift_4__Grupparbete_
{
    public partial class Form1 : Form
    {
        private const string FilePath = "recipes.txt";
        private List<Recipe> recipeList = new List<Recipe>();

        public Form1()
        {
            InitializeComponent();
            LoadRecipes();

        }

        // Loads the .txt file and puts its content in the dataGridView
        private void LoadRecipes()
        {

            if (!File.Exists(FilePath))
            {
                // Create a new empty ".txt" file
                File.Create(FilePath).Close();
            }


            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {                         
                        recipeList.Add(new Recipe { Title = parts[0], Description = parts[1], Type = parts[2] });
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

                foreach (var recipe in recipeList)
                {
                    if (recipe.Title.ToLower().Contains(txtSearch.Text.ToLower())) // Maybe should write it the other way around aka txtSearch.Text.ToLower().Contains(recipe.Title.ToLower())
                    {
                        recipeDataGridView.Rows.Add(recipe.Title);
                    }
                }
            }
        }
        
        // Open a new Form that displays the Title and the description if I select a row.
        private void recipeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (recipeDataGridView.SelectedRows.Count > 0) // Check if there are selected rows so it will not run in to an out of range exception when running the program.  // maybe could have wrote if(dataGridView1.SelectedRows != null)
            {
                // 0 in SelectedRows[0] stands for the last selected row in selected rows.
                DataGridViewRow selectedRow = recipeDataGridView.SelectedRows[0];

                // Code to open a new Form where I display the name and description for the food.

                string selectedTitle = selectedRow.Cells["Title"].Value.ToString();


                // Try to find an recipe object with the same title of the selected row and store it in a variable
                Recipe selectedRecipe = recipeList.FirstOrDefault(recipe => recipe.Title == selectedTitle);

                // If the selectedRecipe doesn't return null
                if (selectedRecipe != null)
                {
                    RecipeDetailsForm detailsForm = new RecipeDetailsForm(selectedRecipe);
                    detailsForm.ShowDialog();
                }

            }
        }
    }
}