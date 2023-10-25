using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_4__Grupparbete_
{
    public partial class RecipeDetailsForm : Form
    {
        public RecipeDetailsForm(Recipe selectedRecipe)
        {
            InitializeComponent();
            titleLabel.Text = selectedRecipe.Title;
            descriptionLabel.Text = selectedRecipe.Description;
            typeLabel.Text = selectedRecipe.Type;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            
            
            
            //EditRecipeDetailsForm detailsForm = new EditRecipeDetailsForm(titleLabel, descriptionLabel, typeLabel);
            //detailsForm.ShowDialog();
        }
    }
}
