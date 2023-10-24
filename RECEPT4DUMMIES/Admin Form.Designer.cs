namespace RECEPT4DUMMIES
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            buttonSave = new Button();
            button3 = new Button();
            label1 = new Label();
            txtBoxSearch = new TextBox();
            textBoxtitel = new TextBox();
            textBoxcategori = new TextBox();
            textBoxingredients = new TextBox();
            textBoxdescription = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(243, 355);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LimeGreen;
            buttonSave.Location = new Point(438, 355);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save ";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(647, 355);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(365, 49);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 3;
            label1.Text = "International Food AB";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(243, 87);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(448, 23);
            txtBoxSearch.TabIndex = 4;
            // 
            // textBoxtitel
            // 
            textBoxtitel.Location = new Point(254, 132);
            textBoxtitel.Name = "textBoxtitel";
            textBoxtitel.Size = new Size(100, 23);
            textBoxtitel.TabIndex = 5;
            textBoxtitel.Text = "Titel";
            // 
            // textBoxcategori
            // 
            textBoxcategori.Location = new Point(413, 132);
            textBoxcategori.Name = "textBoxcategori";
            textBoxcategori.Size = new Size(100, 23);
            textBoxcategori.TabIndex = 6;
            textBoxcategori.Text = "Categori";
            // 
            // textBoxingredients
            // 
            textBoxingredients.Location = new Point(578, 132);
            textBoxingredients.Multiline = true;
            textBoxingredients.Name = "textBoxingredients";
            textBoxingredients.Size = new Size(100, 204);
            textBoxingredients.TabIndex = 7;
            textBoxingredients.Text = "Ingredients";
            // 
            // textBoxdescription
            // 
            textBoxdescription.Location = new Point(254, 173);
            textBoxdescription.Multiline = true;
            textBoxdescription.Name = "textBoxdescription";
            textBoxdescription.Size = new Size(272, 163);
            textBoxdescription.TabIndex = 8;
            textBoxdescription.Text = "Description";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(945, 430);
            Controls.Add(textBoxdescription);
            Controls.Add(textBoxingredients);
            Controls.Add(textBoxcategori);
            Controls.Add(textBoxtitel);
            Controls.Add(txtBoxSearch);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(buttonSave);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonSave;
        private Button button3;
        private Label label1;
        private TextBox txtBoxSearch;
        private TextBox textBoxtitel;
        private TextBox textBoxcategori;
        private TextBox textBoxingredients;
        private TextBox textBoxdescription;
    }
}