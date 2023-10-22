namespace recp_18_ok
{
    partial class admin
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
            Titelbox = new TextBox();
            Katagorybox = new TextBox();
            portionbox = new TextBox();
            ingredienserbox = new RichTextBox();
            Hurbox = new RichTextBox();
            Add = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            searchbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Delete = new Button();
            Update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Titelbox
            // 
            Titelbox.Location = new Point(181, 70);
            Titelbox.Name = "Titelbox";
            Titelbox.Size = new Size(125, 27);
            Titelbox.TabIndex = 0;
            // 
            // Katagorybox
            // 
            Katagorybox.Location = new Point(181, 116);
            Katagorybox.Name = "Katagorybox";
            Katagorybox.Size = new Size(125, 27);
            Katagorybox.TabIndex = 1;
            // 
            // portionbox
            // 
            portionbox.Location = new Point(181, 161);
            portionbox.Name = "portionbox";
            portionbox.Size = new Size(125, 27);
            portionbox.TabIndex = 2;
            // 
            // ingredienserbox
            // 
            ingredienserbox.Location = new Point(40, 223);
            ingredienserbox.Name = "ingredienserbox";
            ingredienserbox.Size = new Size(177, 181);
            ingredienserbox.TabIndex = 3;
            ingredienserbox.Text = "";
            // 
            // Hurbox
            // 
            Hurbox.Location = new Point(248, 223);
            Hurbox.Name = "Hurbox";
            Hurbox.Size = new Size(177, 181);
            Hurbox.TabIndex = 4;
            Hurbox.Text = "";
            // 
            // Add
            // 
            Add.Location = new Point(40, 436);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 5;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(463, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(653, 188);
            dataGridView1.TabIndex = 6;
            
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Titel";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Katagory";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Portion";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ingridienser";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Hur";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(496, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(758, 86);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(125, 27);
            searchbox.TabIndex = 8;
            searchbox.TextChanged += searchbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 73);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 9;
            label1.Text = "Titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 119);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 10;
            label2.Text = "Katagory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-373, 96);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 11;
            label3.Text = "Portion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 233);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 168);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 13;
            label5.Text = "Portion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 200);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 14;
            label6.Text = "Ingridienser";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 200);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 15;
            label7.Text = "Hur";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(496, 49);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 16;
            label8.Text = "Search by catagory";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(758, 49);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 17;
            label9.Text = "Search recept";
            // 
            // Delete
            // 
            Delete.Location = new Point(158, 436);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 18;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Location = new Point(268, 436);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 19;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 486);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchbox);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Add);
            Controls.Add(Hurbox);
            Controls.Add(ingredienserbox);
            Controls.Add(portionbox);
            Controls.Add(Katagorybox);
            Controls.Add(Titelbox);
            Name = "admin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Titelbox;
        private TextBox Katagorybox;
        private TextBox portionbox;
        private RichTextBox ingredienserbox;
        private RichTextBox Hurbox;
        private Button Add;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox comboBox1;
        private TextBox searchbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button Delete;
        private Button Update;
    }
}