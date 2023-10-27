namespace RECEPT4DUMMIES
{
    partial class RecipeDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uppdateRecipeButton = new Button();
            descriptionRichTextBox = new RichTextBox();
            typeTextbox = new TextBox();
            titleTextbox = new TextBox();
            SuspendLayout();
            // 
            // uppdateRecipeButton
            // 
            uppdateRecipeButton.Location = new Point(706, 328);
            uppdateRecipeButton.Margin = new Padding(4, 5, 4, 5);
            uppdateRecipeButton.Name = "uppdateRecipeButton";
            uppdateRecipeButton.Size = new Size(171, 67);
            uppdateRecipeButton.TabIndex = 6;
            uppdateRecipeButton.Text = "Uppdate Recipe";
            uppdateRecipeButton.UseVisualStyleBackColor = true;
            uppdateRecipeButton.Visible = false;
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(35, 82);
            descriptionRichTextBox.Margin = new Padding(4, 5, 4, 5);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.ReadOnly = true;
            descriptionRichTextBox.Size = new Size(663, 313);
            descriptionRichTextBox.TabIndex = 5;
            descriptionRichTextBox.Text = "";
            // 
            // typeTextbox
            // 
            typeTextbox.Location = new Point(429, 25);
            typeTextbox.Margin = new Padding(4, 5, 4, 5);
            typeTextbox.Name = "typeTextbox";
            typeTextbox.ReadOnly = true;
            typeTextbox.Size = new Size(181, 31);
            typeTextbox.TabIndex = 3;
            // 
            // titleTextbox
            // 
            titleTextbox.Location = new Point(35, 25);
            titleTextbox.Margin = new Padding(4, 5, 4, 5);
            titleTextbox.Name = "titleTextbox";
            titleTextbox.ReadOnly = true;
            titleTextbox.Size = new Size(268, 31);
            titleTextbox.TabIndex = 4;
            // 
            // RecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 428);
            Controls.Add(uppdateRecipeButton);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(typeTextbox);
            Controls.Add(titleTextbox);
            Name = "RecipeDetailsForm";
            Text = "RecipeDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uppdateRecipeButton;
        private RichTextBox descriptionRichTextBox;
        private TextBox typeTextbox;
        private TextBox titleTextbox;
    }
}