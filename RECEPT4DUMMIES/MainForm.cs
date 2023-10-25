namespace RECEPT4DUMMIES
{
    public partial class MainForm : Form
    {
        public List<Recipe> recipes = new List<Recipe>();
        public List<Admin> admins = new List<Admin>();

        public bool isAdmin;


        public MainForm()
        {
            InitializeComponent();
        }

        // Lägga till recept i recipe listan och i DataGridView
        private void LoadRecipes()
        {
            // Streamreader för att läsa texfilen och för varje rad skapa en instans av "Recipe" klassen och lägga till den i "recipes" listan
        }


        // Lägga till admins i admins listan
        private void LoadAdmin()
        {
            // Streamreader för att läsa texfilen och för varje rad skapa en instans av "Admin" klassen och lägga till den i "admins" listan
        }


        // Nollställa DataGridView
        private void ResetDataGridView()
        {
            // (namnet på DatagridViewen).Rows.Clear();
        }


        // söka på recept från recipes listan och visa i DataGridView
        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        // Öppna en ny Form när man klickar på en rad för att visa detaljerad information (För tillfället kallar jag Formen för "RecipeDetailsForm"
        // Metod



        // Logga in som Admin
        private void SignInButton_Click(Object sender, EventArgs e)
        {
            // Öppna en ny Forms "FormLogIn" där man kan skriva Användarnamn och lösenord

            // Om inloggningen lyckas så ändras "isAdmin" variabeln i fältet på denna klass till "true"

            // Efter att man har loggat in så går man tillbaka till denna Form
        }


        // Ta bort markerad recipe
        private void DeleteSelectedRecipeButton_Click()
        {
            // Ta bort receptet från listan

        }

    }
}