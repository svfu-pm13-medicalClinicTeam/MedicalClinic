namespace MedicalClinic
{
    partial class deletePatient
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
            this.okButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(120, 150);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 30);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(106, 21);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(133, 35);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Позвонить";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(81, 96);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(182, 20);
            this.phoneTextBox.TabIndex = 2;
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.AutoSize = true;
            this.phoneLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel1.Location = new System.Drawing.Point(117, 56);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(112, 17);
            this.phoneLabel1.TabIndex = 3;
            this.phoneLabel1.Text = "Номер телефона";
            // 
            // deletePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 212);
            this.Controls.Add(this.phoneLabel1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.okButton);
            this.Name = "deletePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel1;
    }
}