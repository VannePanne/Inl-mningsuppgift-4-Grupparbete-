namespace RECEPT4DUMMIES
{
    partial class FormLogIn
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
            SignInButton = new Button();
            label2 = new Label();
            label1 = new Label();
            PasswordTextbox = new TextBox();
            UsernameTextbox = new TextBox();
            SuspendLayout();
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(229, 169);
            SignInButton.Margin = new Padding(4, 5, 4, 5);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(87, 42);
            SignInButton.TabIndex = 7;
            SignInButton.Text = "Sign in";
            SignInButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(149, 120);
            PasswordTextbox.Margin = new Padding(4, 5, 4, 5);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(264, 31);
            PasswordTextbox.TabIndex = 3;
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Location = new Point(149, 37);
            UsernameTextbox.Margin = new Padding(4, 5, 4, 5);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(264, 31);
            UsernameTextbox.TabIndex = 4;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 225);
            Controls.Add(SignInButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextbox);
            Controls.Add(UsernameTextbox);
            Name = "FormLogIn";
            Text = "FormLogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignInButton;
        private Label label2;
        private Label label1;
        private TextBox PasswordTextbox;
        private TextBox UsernameTextbox;
    }
}