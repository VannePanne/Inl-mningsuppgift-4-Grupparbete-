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
            Deletetest = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(1457, 125);
            SignInButton.Margin = new Padding(5, 6, 5, 6);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(144, 73);
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
            dataGridView1.Location = new Point(389, 311);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(875, 490);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 8;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 150;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(659, 182);
            SearchTextbox.Margin = new Padding(5, 6, 5, 6);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(341, 39);
            SearchTextbox.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(1075, 179);
            SearchButton.Margin = new Padding(5, 6, 5, 6);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(139, 49);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(1457, 252);
            signOutButton.Margin = new Padding(5, 6, 5, 6);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(144, 70);
            signOutButton.TabIndex = 4;
            signOutButton.Text = "Sign out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Visible = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // Deletetest
            // 
            Deletetest.Location = new Point(1457, 353);
            Deletetest.Name = "Deletetest";
            Deletetest.Size = new Size(150, 59);
            Deletetest.TabIndex = 5;
            Deletetest.Text = "DeleteTest";
            Deletetest.UseVisualStyleBackColor = true;
            Deletetest.Visible = false;
            Deletetest.MouseClick += Deletetest_MouseClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1737, 1009);
            Controls.Add(Deletetest);
            Controls.Add(signOutButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(SignInButton);
            Margin = new Padding(4);
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
        private Button Deletetest;
    }
}