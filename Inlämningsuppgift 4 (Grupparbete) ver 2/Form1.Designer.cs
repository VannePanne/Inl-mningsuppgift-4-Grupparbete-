namespace Inlämningsuppgift_4__Grupparbete_
{
    partial class Form1
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            recipeDataGridView = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            btnSignIn = new Button();
            ((System.ComponentModel.ISupportInitialize)recipeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(494, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(174, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(689, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // recipeDataGridView
            // 
            recipeDataGridView.AllowUserToAddRows = false;
            recipeDataGridView.AllowUserToDeleteRows = false;
            recipeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recipeDataGridView.Columns.AddRange(new DataGridViewColumn[] { Title });
            recipeDataGridView.Location = new Point(211, 168);
            recipeDataGridView.Name = "recipeDataGridView";
            recipeDataGridView.ReadOnly = true;
            recipeDataGridView.RowTemplate.Height = 25;
            recipeDataGridView.Size = new Size(602, 150);
            recipeDataGridView.TabIndex = 4;
            recipeDataGridView.SelectionChanged += recipeDataGridView_SelectionChanged;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(895, 27);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 445);
            Controls.Add(btnSignIn);
            Controls.Add(recipeDataGridView);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)recipeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView recipeDataGridView;
        private DataGridViewTextBoxColumn Title;
        private Button btnSignIn;
    }
}