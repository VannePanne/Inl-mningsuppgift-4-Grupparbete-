namespace RECEPT4DUMMIES
{
    public partial class MainForm : Form
    {
        public List<Recipe> recipes = new List<Recipe>();
        public List<Admin> admins = new List<Admin>();
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private Button SearchButton;
        private Button SignInButton;
        private Button signOutButton;
        private Button button1;
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

        private void InitializeComponent()
        {
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            SearchButton = new Button();
            SignInButton = new Button();
            signOutButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(78, 78);
            SearchTextbox.Margin = new Padding(4, 5, 4, 5);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(263, 31);
            SearchTextbox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title });
            dataGridView1.Location = new Point(78, 173);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(673, 383);
            dataGridView1.TabIndex = 4;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 8;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 150;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(373, 78);
            SearchButton.Margin = new Padding(4, 5, 4, 5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(107, 31);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(705, 13);
            SignInButton.Margin = new Padding(4, 5, 4, 5);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(111, 54);
            SignInButton.TabIndex = 6;
            SignInButton.Text = "Sign in";
            SignInButton.UseVisualStyleBackColor = true;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(824, 13);
            signOutButton.Margin = new Padding(4, 5, 4, 5);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(111, 55);
            signOutButton.TabIndex = 7;
            signOutButton.Text = "Sign out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(772, 173);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(147, 54);
            button1.TabIndex = 8;
            button1.Text = "Nytt Recept";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(948, 629);
            Controls.Add(button1);
            Controls.Add(signOutButton);
            Controls.Add(SignInButton);
            Controls.Add(SearchButton);
            Controls.Add(dataGridView1);
            Controls.Add(SearchTextbox);
            Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        // Ta bort markerad recipe
        private void DeleteSelectedRecipeButton_Click()
        {
            // Ta bort receptet från listan

        }

    }
}