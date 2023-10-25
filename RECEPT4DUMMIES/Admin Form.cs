namespace RECEPT4DUMMIES
{
    public partial class MainForm : Form
    {
        Recept recept = new Recept();
        public MainForm()
        {
            InitializeComponent();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /* string titel= textBoxtitel.Text;
             string categori= textBoxcategori.Text;
             string ingredinser = textBoxingredients.Text;
             string description= textBoxdescription.Text;
             recept.Save(titel, categori, ingredinser, description);*/
            recept.Save(textBoxtitel.Text, textBoxcategori.Text, textBoxingredients.Text, textBoxdescription.Text);
        }

    }
}