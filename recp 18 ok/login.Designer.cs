namespace recp_18_ok
{
    partial class login
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
            label1 = new Label();
            label2 = new Label();
            Userbox = new TextBox();
            passbox = new TextBox();
            Logg = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 125);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 174);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Userbox
            // 
            Userbox.Location = new Point(237, 122);
            Userbox.Name = "Userbox";
            Userbox.Size = new Size(125, 27);
            Userbox.TabIndex = 2;
            // 
            // passbox
            // 
            passbox.Location = new Point(237, 167);
            passbox.Name = "passbox";
            passbox.Size = new Size(125, 27);
            passbox.TabIndex = 3;
            // 
            // Logg
            // 
            Logg.Location = new Point(237, 233);
            Logg.Name = "Logg";
            Logg.Size = new Size(94, 29);
            Logg.TabIndex = 4;
            Logg.Text = "Logga in";
            Logg.UseVisualStyleBackColor = true;
            Logg.Click += Logg_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Logg);
            Controls.Add(passbox);
            Controls.Add(Userbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Userbox;
        private TextBox passbox;
        private Button Logg;
    }
}