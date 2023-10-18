namespace Inlämningsuppgift_4__Grupparbete_
{
    public partial class Form1 : Form
    {
        private const string FilePath = "recipes.txt";

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
                    {                         // Titel   -Description  -Type
                        recipeDataGridView.Rows.Add(parts[0]);
                    }
                }
            }

        }

        // Remove everything from the dataGridView method
        private void ResetGridView()
        {
            recipeDataGridView.Rows.Clear();
        }


        // Search for recipes method
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                ResetGridView();
                LoadRecipes();
            }
            else
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    ResetGridView();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string Title = parts[0];
                            string Description = parts[1];
                            string Type = parts[2];


                            int txtSearchLength = txtSearch.Text.ToString().Length;

                            try // this removes the posibility of crashing the program by having a search length longer than the length of the shortest name or address
                            {
                                // Extracting substrings with the same length as the searchbar
                                string TitelSubstring = Title.Substring(0, txtSearchLength).ToLower();

                                // if the substring matches what's currently written in the searchbar then add the row from the text file in the datagrid
                                if (TitelSubstring == txtSearch.Text.ToLower())
                                {
                                    recipeDataGridView.Rows.Add(Title);
                                }
                            }
                            catch (Exception f)
                            {

                            }

                        }
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

                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3 && parts[0] == selectedTitle)
                        {
                            string title = parts[0];
                            string description = parts[1];
                            string type = parts[2];

                            // Open the RecipeDetailsForm and pass the selected recipe
                            RecipeDetailsForm detailsForm = new RecipeDetailsForm(title, description, type);
                            detailsForm.ShowDialog();
                            break; // Exit the loop after finding the selected recipe
                        }
                    }
                }

            }
        }
    }


}