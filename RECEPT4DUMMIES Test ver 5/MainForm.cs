using System.Xml.Linq;
using System.Diagnostics;

namespace RECEPT4DUMMIES
{
    public partial class MainForm : Form
    {
        public List<Recipe> recipes { get; set; } = new List<Recipe>();
        public List<Admin> admins { get; set; } = new List<Admin>();
        private const string AdminFilePath = @"admins.txt";
        private const string RecipeFilePath = @"recipes.txt";
        private bool isAdminSignedIn { get; set; }


        public MainForm()
        {
            InitializeComponent();
            LoadAdmin();
            LoadRecipes();
        }

        // Lägga till recept i recipe listan och i DataGridView
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
                        recipes.Add(new Recipe { Title = parts[0], Description = parts[1], Type = parts[2] });
                        dataGridView1.Rows.Add(parts[0]);
                    }
                }
            }
        }


        // Lägga till admins i admins listan
        private void LoadAdmin()
        {
            using (StreamReader reader = new StreamReader(AdminFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        admins.Add(new Admin { Username = parts[0], Password = parts[1] });
                    }
                }
            }
        }


        // Nollställa DataGridView
        private void ResetDataGridView()
        {
            dataGridView1.Rows.Clear();
        }


        // söka på recept från recipes listan och visa i DataGridView
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchButton.Text == string.Empty)
            {
                ResetDataGridView();
                LoadRecipes();
            }
            else
            {
                ResetDataGridView();
                foreach (var recipe in recipes)
                {
                    if (recipe.Title.ToLower().Contains(SearchTextbox.Text.ToLower()) || recipe.Type.ToLower().Contains(SearchTextbox.Text.ToLower())) // SearchTextbox.Text.ToLower().Contains(recipe.Title.ToLower()) || SearchTextbox.Text.ToLower().Contains(recipe.Type.ToLower())
                    {
                        dataGridView1.Rows.Add(recipe.Title);
                    }
                }
            }
        }

        // Öppna en ny Form när man klickar på en rad för att visa detaljerad information. Om du är inloggad som "Admin" så kan du även redigera receptet
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string selectedTitle = selectedRow.Cells[0].Value.ToString();
                Recipe selectedRecipe = recipes.FirstOrDefault(recipe => recipe.Title == selectedTitle);

                // Om selectedRecipe inte returnerar null
                if (selectedRecipe != null)
                {
                    RecipeDetailsForm detailsForm = new RecipeDetailsForm(selectedRecipe, isAdminSignedIn);
                    detailsForm.ShowDialog();

                    Recipe updatedRecipe = detailsForm.UppdatedRecipe;

                    if (detailsForm.DeleteRecipe)
                    {
                        recipes.Remove(selectedRecipe);
                        UppdateTextFile();

                        int rowIndex = selectedRow.Index;
                        dataGridView1.Rows.RemoveAt(rowIndex);
                    }

                    else if (updatedRecipe.Title != selectedRecipe.Title || updatedRecipe.Description != selectedRecipe.Description || updatedRecipe.Type != selectedRecipe.Type)
                    {
                        recipes.Remove(selectedRecipe);
                        recipes.Add(updatedRecipe);

                        UppdateTextFile();

                        // Uppdaterar DataGridView utan att rensa hela den och läsa om den. Detta fixar buggen med att recept duppliceras
                        int rowIndex = selectedRow.Index;
                        dataGridView1.Rows[rowIndex].Cells[0].Value = updatedRecipe.Title;
                    }
                }
            }

        }


        // Logga in som Admin
        private void SignInButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormLogIn login = new FormLogIn(admins);
            login.ShowDialog();

            isAdminSignedIn = login.IsLoginSuccessful;

            this.Show();

            if (isAdminSignedIn)
            {
                SignInButton.Visible = false; // kan alternativt skriva "!isAdminSignedIn" istället för "false"
                signOutButton.Visible = true;
                AddRecipeButton.Visible = true;
            }
        }

        // Logga ut
        private void signOutButton_Click(object sender, EventArgs e)
        {
            isAdminSignedIn = false;
            signOutButton.Visible = false;
            SignInButton.Visible = true;
            AddRecipeButton.Visible = false;
        }


        // Ta bort markerad recipe
        private void DeleteSelectedRecipeButton_Click()
        {
            // Ta bort receptet från listan

        }

        // Uppdatera recept textfilen
        private void UppdateTextFile()
        {
            Debug.WriteLine("Updating text file...");
            using (StreamWriter writer = new StreamWriter(RecipeFilePath, false))
            {
                foreach (Recipe recipe in recipes)
                {
                    writer.WriteLine($"{recipe.Title},{recipe.Description},{recipe.Type}");
                }
            }
            Debug.WriteLine("Text file updated.");
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeDetailsForm detailsForm = new RecipeDetailsForm(isAdminSignedIn);
            detailsForm.ShowDialog();

            if (detailsForm.AddRecipe)
            {
                Recipe newRecipe = detailsForm.UppdatedRecipe;
                if (newRecipe != null)
                {
                    recipes.Add(newRecipe);
                    dataGridView1.Rows.Add(newRecipe.Title);
                    UppdateTextFile(); // Uppdatera textfilen med det nya receptet
                }
            }
        }
    }
}