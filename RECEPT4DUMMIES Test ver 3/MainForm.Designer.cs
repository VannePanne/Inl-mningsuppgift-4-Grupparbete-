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
            SignInButton = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            SearchTextbox = new TextBox();
            SearchButton = new Button();
            signOutButton = new Button();
            AddRecipeButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(785, 59);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(78, 34);
            SignInButton.TabIndex = 0;
            SignInButton.Text = "Sign in";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title });
            dataGridView1.Location = new Point(209, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(471, 230);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(355, 85);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(185, 23);
            SearchTextbox.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(579, 84);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(785, 118);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(78, 33);
            signOutButton.TabIndex = 4;
            signOutButton.Text = "Sign out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Visible = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // AddRecipeButton
            // 
            AddRecipeButton.Location = new Point(788, 205);
            AddRecipeButton.Name = "AddRecipeButton";
            AddRecipeButton.Size = new Size(75, 23);
            AddRecipeButton.TabIndex = 5;
            AddRecipeButton.Text = "Add Recipe";
            AddRecipeButton.UseVisualStyleBackColor = true;
            AddRecipeButton.Visible = false;
            AddRecipeButton.Click += AddRecipeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(788, 266);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(120, 70);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "(har ej skrivit kod för denna)Remove Recipe";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 473);
            Controls.Add(DeleteButton);
            Controls.Add(AddRecipeButton);
            Controls.Add(signOutButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(SignInButton);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignInButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private TextBox SearchTextbox;
        private Button SearchButton;
        private Button signOutButton;
        private Button AddRecipeButton;
        private Button DeleteButton;
    }
}