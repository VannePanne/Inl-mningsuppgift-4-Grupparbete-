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
            titleTextbox = new TextBox();
            typeTextbox = new TextBox();
            descriptionRichTextBox = new RichTextBox();
            uppdateRecipeButton = new Button();
            SuspendLayout();
            // 
            // titleTextbox
            // 
            titleTextbox.Location = new Point(295, 24);
            titleTextbox.Name = "titleTextbox";
            titleTextbox.ReadOnly = true;
            titleTextbox.Size = new Size(134, 23);
            titleTextbox.TabIndex = 0;
            titleTextbox.DoubleClick += titleTextbox_DoubleClick;
            // 
            // typeTextbox
            // 
            typeTextbox.Location = new Point(665, 24);
            typeTextbox.Name = "typeTextbox";
            typeTextbox.ReadOnly = true;
            typeTextbox.Size = new Size(63, 23);
            typeTextbox.TabIndex = 0;
            typeTextbox.DoubleClick += typeTextbox_DoubleClick;
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(151, 105);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.ReadOnly = true;
            descriptionRichTextBox.Size = new Size(447, 245);
            descriptionRichTextBox.TabIndex = 1;
            descriptionRichTextBox.Text = "";
            descriptionRichTextBox.DoubleClick += descriptionRichTextBox_DoubleClick;
            // 
            // uppdateRecipeButton
            // 
            uppdateRecipeButton.Location = new Point(665, 94);
            uppdateRecipeButton.Name = "uppdateRecipeButton";
            uppdateRecipeButton.Size = new Size(104, 23);
            uppdateRecipeButton.TabIndex = 2;
            uppdateRecipeButton.Text = "Uppdate Recipe";
            uppdateRecipeButton.UseVisualStyleBackColor = true;
            uppdateRecipeButton.Visible = false;
            uppdateRecipeButton.Click += uppdateRecipeButton_Click;
            // 
            // RecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private TextBox titleTextbox;
        private TextBox typeTextbox;
        private RichTextBox descriptionRichTextBox;
        private Button uppdateRecipeButton;
    }
}