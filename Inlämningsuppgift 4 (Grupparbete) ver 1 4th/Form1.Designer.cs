﻿namespace Inlämningsuppgift_4__Grupparbete_
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            recipeDataGridView = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            txtName = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)recipeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 100);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Mat Typ";
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
            // txtName
            // 
            txtName.Location = new Point(895, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(895, 100);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(828, 108);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Beskrivning";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(828, 67);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 1;
            label3.Text = "Titel";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Meat", "Fish", "Salad", "Soup", "Dessert" });
            comboBox1.Location = new Point(195, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 445);
            Controls.Add(comboBox1);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(recipeDataGridView);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)recipeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView recipeDataGridView;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Title;
    }
}