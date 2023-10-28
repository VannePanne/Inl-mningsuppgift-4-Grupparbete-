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
using System.Diagnostics;

namespace RECEPT4DUMMIES
{
    public partial class RecipeDetailsForm : Form
    {
        Recipe selectedRecipe;
        public Recipe UppdatedRecipe { get; set; }
        bool isAdminSignedIn;
        public bool DeleteRecipe { get; private set; }
        public bool AddRecipe { get; private set; }

        public RecipeDetailsForm(Recipe selectedRecipe, bool isAdminSignedIn)
        {
            InitializeComponent();


            // Om du klickar på att lägga till ett nytt recept i MainForm
            if (selectedRecipe == null)
            {
                selectedRecipe = new Recipe();
                AddNewRecipeUserInterfaceSettings();
            }
            // Om du klickar/markerar ett recept i MainForm
            else
            {
                // kopierar selectedRecipe egenskaper så om båda objekten har samma sak så uppdateras inte recept listan in MainForm. Behöver liksom inte ta bort och lägga till recept om man inte har ändrat ett recept med andra ord
                UppdatedRecipe = new Recipe
                {
                    Title = selectedRecipe.Title,
                    Description = selectedRecipe.Description,
                    Type = selectedRecipe.Type
                };
                StandardUserInterfaceSettings();
            }

            this.selectedRecipe = selectedRecipe;
            this.isAdminSignedIn = isAdminSignedIn;


        }


        private void StandardUserInterfaceSettings()
        {
            // Visa knappar för redigering om du är Admin
            if (isAdminSignedIn)
            {
                uppdateRecipeButton.Visible = true;
                DeleteRecipeButton.Visible = true;
            }

            // Tar bort Borderstyle för att göra så att textboxarna liknar mera labels i utseendet
            titleTextbox.BorderStyle = BorderStyle.None;
            typeTextbox.BorderStyle = BorderStyle.None;
            descriptionRichTextBox.BorderStyle = BorderStyle.None;

            // Sätta färgen på textboxarna till samma som finns för Form bakgrunden
            titleTextbox.BackColor = this.BackColor;
            typeTextbox.BackColor = this.BackColor;
            descriptionRichTextBox.BackColor = this.BackColor;

            // lägga till receptet i textrutorna
            titleTextbox.Text = selectedRecipe.Title;
            typeTextbox.Text = selectedRecipe.Type;
            //descriptionRichTextBox.Text = selectedRecipe.Description;

            descriptionRichTextBox.Lines = selectedRecipe.Description.Split(@"\n");


        }

        private void AddNewRecipeUserInterfaceSettings()
        {
            titleTextbox.ReadOnly = false;
            typeTextbox.ReadOnly = false;
            descriptionRichTextBox.ReadOnly = false;

            AddRecipeButton.Visible = true;

            // Tar bort Borderstyle för att göra så att textboxarna liknar mera labels i utseendet
            titleTextbox.BorderStyle = BorderStyle.None;
            typeTextbox.BorderStyle = BorderStyle.None;
            descriptionRichTextBox.BorderStyle = BorderStyle.None;
        }

        // Kanske kunde istället lagt till en knapp som kan heta "Enable Edit mode". Då kan jag ändra bakgrundsfärgen för alla textrutor samtidigt men vad jag har skrivit nedan fungerar med.

        private void titleTextbox_DoubleClick(object sender, EventArgs e)
        {
            if (isAdminSignedIn && UppdatedRecipe != null)
            {
                titleTextbox.ReadOnly = !titleTextbox.ReadOnly;

                if (titleTextbox.BackColor == this.BackColor)
                {
                    titleTextbox.BackColor = Color.White;
                }
                else
                {
                    titleTextbox.BackColor = this.BackColor;
                }


            }

        }

        private void descriptionRichTextBox_DoubleClick(object sender, EventArgs e)
        {
            if (isAdminSignedIn && UppdatedRecipe != null)
            {
                descriptionRichTextBox.ReadOnly = !descriptionRichTextBox.ReadOnly;

                if (descriptionRichTextBox.BackColor == this.BackColor)
                {
                    descriptionRichTextBox.BackColor = Color.White;
                }
                else
                {
                    descriptionRichTextBox.BackColor = this.BackColor;
                }
            }
        }

        private void typeTextbox_DoubleClick(object sender, EventArgs e)
        {
            if (isAdminSignedIn && UppdatedRecipe != null)
            {
                typeTextbox.ReadOnly = !typeTextbox.ReadOnly;

                if (typeTextbox.BackColor == this.BackColor)
                {
                    typeTextbox.BackColor = Color.White;
                }
                else
                {
                    typeTextbox.BackColor = this.BackColor;
                }
            }

        }

        private void uppdateRecipeButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Update button clicked in RecipeDetailsForm.");

            UppdatedRecipe.Title = titleTextbox.Text;
            UppdatedRecipe.Type = typeTextbox.Text;
            UppdatedRecipe.Description = string.Join(@"\n", descriptionRichTextBox.Lines);

            // kan tta bort sen this.close
            this.Close();
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            DeleteRecipe = true;
            this.Close();
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            AddRecipe = true;
            UppdatedRecipe = new Recipe
            {
                Title = titleTextbox.Text,
                Type = typeTextbox.Text,
                Description = descriptionRichTextBox.Text
            };
            this.Close();
        }



        // Om du klickar på "Enter" på nuvarande textruta så ändras den till "Read Only" och recept objektet updateras i "recipes" listan som finnns i "MainForm" klassen.
        //private void textbox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        textBox.ReadOnly = true;
        //    }
        //}
    }
}
