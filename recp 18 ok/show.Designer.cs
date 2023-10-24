namespace recp_18_ok
{
    partial class show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show));
            pictureBox1 = new PictureBox();
            lbltitel = new Label();
            lblkat = new Label();
            lblportion = new Label();
            lbling = new Label();
            lblhur = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbltitel
            // 
            lbltitel.AutoSize = true;
            lbltitel.Location = new Point(154, 156);
            lbltitel.Name = "lbltitel";
            lbltitel.Size = new Size(0, 20);
            lbltitel.TabIndex = 1;
            // 
            // lblkat
            // 
            lblkat.AutoSize = true;
            lblkat.Location = new Point(154, 196);
            lblkat.Name = "lblkat";
            lblkat.Size = new Size(0, 20);
            lblkat.TabIndex = 2;
            // 
            // lblportion
            // 
            lblportion.AutoSize = true;
            lblportion.Location = new Point(154, 232);
            lblportion.Name = "lblportion";
            lblportion.Size = new Size(0, 20);
            lblportion.TabIndex = 3;
            // 
            // lbling
            // 
            lbling.AutoSize = true;
            lbling.Location = new Point(113, 306);
            lbling.Name = "lbling";
            lbling.Size = new Size(0, 20);
            lbling.TabIndex = 5;
            // 
            // lblhur
            // 
            lblhur.AutoSize = true;
            lblhur.Location = new Point(389, 306);
            lblhur.Name = "lblhur";
            lblhur.Size = new Size(0, 20);
            lblhur.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 152);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "Recept titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 196);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 8;
            label2.Text = "Recept Katagory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 128);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 241);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 9;
            label3.Text = "Recept Portion";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 128);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(113, 286);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 10;
            label4.Text = "Ingredienser";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 128);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(389, 286);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 11;
            label5.Text = "Hur";
            // 
            // show
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 817);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblhur);
            Controls.Add(lbling);
            Controls.Add(lblportion);
            Controls.Add(lblkat);
            Controls.Add(lbltitel);
            Controls.Add(pictureBox1);
            Name = "show";
            Text = "show";
            Load += show_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbltitel;
        private Label lblkat;
        private Label lblportion;
        private Label lbling;
        private Label lblhur;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}