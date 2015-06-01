namespace MedicalClinic
{
    partial class UserWindow
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
            this.registrationButton = new System.Windows.Forms.Button();
            this.editScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(190, 80);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(150, 45);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // editScheduleButton
            // 
            this.editScheduleButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editScheduleButton.Location = new System.Drawing.Point(190, 200);
            this.editScheduleButton.Name = "editScheduleButton";
            this.editScheduleButton.Size = new System.Drawing.Size(150, 45);
            this.editScheduleButton.TabIndex = 1;
            this.editScheduleButton.Text = "Редактирование расписания";
            this.editScheduleButton.UseVisualStyleBackColor = true;
            this.editScheduleButton.Click += new System.EventHandler(this.editSchedule_Click);
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 342);
            this.Controls.Add(this.editScheduleButton);
            this.Controls.Add(this.registrationButton);
            this.Name = "UserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно пользователя";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button editScheduleButton;
    }
}