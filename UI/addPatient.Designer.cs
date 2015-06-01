namespace MedicalClinic
{
    partial class addPatient
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.addUserButton.Location = new System.Drawing.Point(120, 250);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 30);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(185, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 20);
            this.nameTextBox.TabIndex = 13;
            this.nameTextBox.UseSystemPasswordChar = true;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(185, 50);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(110, 20);
            this.surnameTextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(35, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 19);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(35, 50);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(72, 19);
            this.surnameLabel.TabIndex = 10;
            this.surnameLabel.Text = "Фамилия";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(185, 150);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(110, 20);
            this.patronymicTextBox.TabIndex = 16;
            this.patronymicTextBox.UseSystemPasswordChar = true;
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicLabel.Location = new System.Drawing.Point(35, 150);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(73, 19);
            this.patronymicLabel.TabIndex = 15;
            this.patronymicLabel.Text = "Отчество";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(185, 200);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(110, 20);
            this.passwordTextBox.TabIndex = 18;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(35, 200);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(66, 19);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "Паспорт";
            // 
            // addPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 325);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Name = "addPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}