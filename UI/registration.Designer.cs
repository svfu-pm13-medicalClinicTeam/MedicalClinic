namespace MedicalClinic
{
    partial class registration
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
            this.doctorOrPatientComboBox = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.passportLabel = new System.Windows.Forms.Label();
            this.manRadioButton = new System.Windows.Forms.RadioButton();
            this.womanRadioButton = new System.Windows.Forms.RadioButton();
            this.passportTextBox1 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.innLabel = new System.Windows.Forms.Label();
            this.snilsLabel = new System.Windows.Forms.Label();
            this.specializationLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.snilsTextBox = new System.Windows.Forms.TextBox();
            this.specializationTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.policyLabel = new System.Windows.Forms.Label();
            this.policyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // doctorOrPatientComboBox
            // 
            this.doctorOrPatientComboBox.FormattingEnabled = true;
            this.doctorOrPatientComboBox.Items.AddRange(new object[] {
            "Доктор",
            "Пациент"});
            this.doctorOrPatientComboBox.Location = new System.Drawing.Point(115, 10);
            this.doctorOrPatientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.doctorOrPatientComboBox.Name = "doctorOrPatientComboBox";
            this.doctorOrPatientComboBox.Size = new System.Drawing.Size(100, 25);
            this.doctorOrPatientComboBox.TabIndex = 0;
            this.doctorOrPatientComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorOrPatientComboBox_SelectedIndexChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectLabel.Location = new System.Drawing.Point(10, 10);
            this.selectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(71, 17);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "Выберите";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(10, 50);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(64, 17);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(10, 90);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(36, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Имя";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicLabel.Location = new System.Drawing.Point(10, 130);
            this.patronymicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(69, 17);
            this.patronymicLabel.TabIndex = 4;
            this.patronymicLabel.Text = "Отчество";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(10, 170);
            this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(103, 17);
            this.dateOfBirthLabel.TabIndex = 5;
            this.dateOfBirthLabel.Text = "Дата рождения";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(115, 50);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 25);
            this.SurnameTextBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(115, 90);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 25);
            this.NameTextBox.TabIndex = 11;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(115, 130);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(100, 25);
            this.patronymicTextBox.TabIndex = 12;
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(115, 170);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(100, 25);
            this.dateOfBirthTextBox.TabIndex = 13;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(10, 210);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(33, 17);
            this.genderLabel.TabIndex = 14;
            this.genderLabel.Text = "Пол";
            // 
            // passportLabel
            // 
            this.passportLabel.AutoSize = true;
            this.passportLabel.Location = new System.Drawing.Point(10, 250);
            this.passportLabel.Name = "passportLabel";
            this.passportLabel.Size = new System.Drawing.Size(61, 17);
            this.passportLabel.TabIndex = 15;
            this.passportLabel.Text = "Паспорт";
            // 
            // manRadioButton
            // 
            this.manRadioButton.AutoSize = true;
            this.manRadioButton.Location = new System.Drawing.Point(115, 210);
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.Size = new System.Drawing.Size(39, 21);
            this.manRadioButton.TabIndex = 18;
            this.manRadioButton.TabStop = true;
            this.manRadioButton.Text = "М";
            this.manRadioButton.UseVisualStyleBackColor = true;
            // 
            // womanRadioButton
            // 
            this.womanRadioButton.AutoSize = true;
            this.womanRadioButton.Location = new System.Drawing.Point(175, 210);
            this.womanRadioButton.Name = "womanRadioButton";
            this.womanRadioButton.Size = new System.Drawing.Size(39, 21);
            this.womanRadioButton.TabIndex = 19;
            this.womanRadioButton.TabStop = true;
            this.womanRadioButton.Text = "Ж";
            this.womanRadioButton.UseVisualStyleBackColor = true;
            // 
            // passportTextBox1
            // 
            this.passportTextBox1.Location = new System.Drawing.Point(115, 250);
            this.passportTextBox1.Name = "passportTextBox1";
            this.passportTextBox1.Size = new System.Drawing.Size(100, 25);
            this.passportTextBox1.TabIndex = 20;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(395, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 35);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // innLabel
            // 
            this.innLabel.AutoSize = true;
            this.innLabel.Location = new System.Drawing.Point(280, 10);
            this.innLabel.Name = "innLabel";
            this.innLabel.Size = new System.Drawing.Size(41, 17);
            this.innLabel.TabIndex = 22;
            this.innLabel.Text = "ИНН";
            // 
            // snilsLabel
            // 
            this.snilsLabel.AutoSize = true;
            this.snilsLabel.Location = new System.Drawing.Point(280, 50);
            this.snilsLabel.Name = "snilsLabel";
            this.snilsLabel.Size = new System.Drawing.Size(60, 17);
            this.snilsLabel.TabIndex = 23;
            this.snilsLabel.Text = "СНИЛС";
            // 
            // specializationLabel
            // 
            this.specializationLabel.AutoSize = true;
            this.specializationLabel.Location = new System.Drawing.Point(280, 90);
            this.specializationLabel.Name = "specializationLabel";
            this.specializationLabel.Size = new System.Drawing.Size(101, 17);
            this.specializationLabel.TabIndex = 24;
            this.specializationLabel.Text = "Специализация";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(280, 130);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(73, 17);
            this.categoryLabel.TabIndex = 25;
            this.categoryLabel.Text = "Категория";
            // 
            // innTextBox
            // 
            this.innTextBox.Location = new System.Drawing.Point(395, 10);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(100, 25);
            this.innTextBox.TabIndex = 26;
            // 
            // snilsTextBox
            // 
            this.snilsTextBox.Location = new System.Drawing.Point(395, 50);
            this.snilsTextBox.Name = "snilsTextBox";
            this.snilsTextBox.Size = new System.Drawing.Size(100, 25);
            this.snilsTextBox.TabIndex = 27;
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.Location = new System.Drawing.Point(395, 90);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(100, 25);
            this.specializationTextBox.TabIndex = 28;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(395, 130);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 25);
            this.categoryTextBox.TabIndex = 29;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(280, 170);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(60, 17);
            this.phoneLabel.TabIndex = 30;
            this.phoneLabel.Text = "Телефон";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(395, 170);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 25);
            this.phoneTextBox.TabIndex = 31;
            // 
            // policyLabel
            // 
            this.policyLabel.AutoSize = true;
            this.policyLabel.Location = new System.Drawing.Point(280, 10);
            this.policyLabel.Name = "policyLabel";
            this.policyLabel.Size = new System.Drawing.Size(47, 17);
            this.policyLabel.TabIndex = 32;
            this.policyLabel.Text = "Полис";
            this.policyLabel.Visible = false;
            // 
            // policyTextBox
            // 
            this.policyTextBox.Location = new System.Drawing.Point(395, 10);
            this.policyTextBox.Name = "policyTextBox";
            this.policyTextBox.Size = new System.Drawing.Size(100, 25);
            this.policyTextBox.TabIndex = 33;
            this.policyTextBox.Visible = false;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 308);
            this.Controls.Add(this.policyTextBox);
            this.Controls.Add(this.policyLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.specializationTextBox);
            this.Controls.Add(this.snilsTextBox);
            this.Controls.Add(this.innTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.specializationLabel);
            this.Controls.Add(this.snilsLabel);
            this.Controls.Add(this.innLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passportTextBox1);
            this.Controls.Add(this.womanRadioButton);
            this.Controls.Add(this.manRadioButton);
            this.Controls.Add(this.passportLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.doctorOrPatientComboBox);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doctorOrPatientComboBox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label passportLabel;
        private System.Windows.Forms.RadioButton manRadioButton;
        private System.Windows.Forms.RadioButton womanRadioButton;
        private System.Windows.Forms.TextBox passportTextBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label innLabel;
        private System.Windows.Forms.Label snilsLabel;
        private System.Windows.Forms.Label specializationLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox snilsTextBox;
        private System.Windows.Forms.TextBox specializationTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label policyLabel;
        private System.Windows.Forms.TextBox policyTextBox;
    }
}