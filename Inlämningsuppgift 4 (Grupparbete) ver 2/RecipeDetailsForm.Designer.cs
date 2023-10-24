namespace Inlämningsuppgift_4__Grupparbete_
{
    partial class RecipeDetailsForm
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
            titleLabel = new Label();
            typeLabel = new Label();
            descriptionLabel = new Label();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(307, 33);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(60, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(674, 59);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(31, 15);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(318, 145);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(89, 21);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(44, 33);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // RecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(descriptionLabel);
            Controls.Add(typeLabel);
            Controls.Add(titleLabel);
            Name = "RecipeDetailsForm";
            Text = "RecipeDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label typeLabel;
        private Label descriptionLabel;
        private Button btnEdit;
    }
}