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
            UsernameTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Location = new Point(380, 126);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(200, 23);
            UsernameTextbox.TabIndex = 0;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(380, 175);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(200, 23);
            PasswordTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 129);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 175);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(352, 241);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(75, 23);
            SignInButton.TabIndex = 2;
            SignInButton.Text = "Sign in";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private TextBox UsernameTextbox;
        private TextBox PasswordTextbox;
        private Label label1;
        private Label label2;
        private Button SignInButton;
    }
}