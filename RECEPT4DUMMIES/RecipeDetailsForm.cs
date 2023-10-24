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

namespace RECEPT4DUMMIES
{
    public partial class RecipeDetailsForm : Form
    {
        public RecipeDetailsForm()
        {
            InitializeComponent();
        }

        // Dubbelklicka på Textrutorna för att kunna ändra dem om du är inloggad som en admin. Om inte så händer inget.
        private void textbox_DoubleClick(object sender, EventArgs e)
        {
            textBox.ReadOnly = !textBox.ReadOnly;
        }


        // Om du klickar på "Enter" på nuvarande textruta så ändras den till "Read Only" och recept objektet updateras i "recipes" listan som finnns i "MainForm" klassen.
    }
}
