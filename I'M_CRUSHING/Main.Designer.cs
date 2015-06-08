namespace MedicalClinic
{
    partial class Main
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
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.policyLabel = new System.Windows.Forms.Label();
            this.policyTextBox = new System.Windows.Forms.TextBox();
            this.specializationTextBox = new System.Windows.Forms.TextBox();
            this.specializationLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.busyCheckBox = new System.Windows.Forms.CheckBox();
            this.админToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аыToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.админToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorOrPatientComboBox
            // 
            this.doctorOrPatientComboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorOrPatientComboBox.FormattingEnabled = true;
            this.doctorOrPatientComboBox.Items.AddRange(new object[] {
            "Доктор",
            "Пациент"});
            this.doctorOrPatientComboBox.Location = new System.Drawing.Point(128, 43);
            this.doctorOrPatientComboBox.Name = "doctorOrPatientComboBox";
            this.doctorOrPatientComboBox.Size = new System.Drawing.Size(100, 25);
            this.doctorOrPatientComboBox.TabIndex = 0;
            this.doctorOrPatientComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorOrPatientComboBox_SelectedIndexChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectLabel.Location = new System.Drawing.Point(23, 43);
            this.selectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(71, 17);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Выберите";
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.scheduleDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addColumn,
            this.deleteColumn});
            this.scheduleDataGridView.Location = new System.Drawing.Point(12, 224);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.RowHeadersWidth = 30;
            this.scheduleDataGridView.Size = new System.Drawing.Size(639, 146);
            this.scheduleDataGridView.TabIndex = 3;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(431, 39);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 4;
            // 
            // toTimePicker2
            // 
            this.toTimePicker2.Location = new System.Drawing.Point(431, 79);
            this.toTimePicker2.Name = "toTimePicker2";
            this.toTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.toTimePicker2.TabIndex = 5;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromLabel.Location = new System.Drawing.Point(361, 39);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(18, 17);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "C";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLabel.Location = new System.Drawing.Point(361, 79);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(26, 17);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "По";
            // 
            // policyLabel
            // 
            this.policyLabel.AutoSize = true;
            this.policyLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.policyLabel.Location = new System.Drawing.Point(23, 83);
            this.policyLabel.Name = "policyLabel";
            this.policyLabel.Size = new System.Drawing.Size(47, 17);
            this.policyLabel.TabIndex = 8;
            this.policyLabel.Text = "Полис";
            this.policyLabel.Visible = false;
            // 
            // policyTextBox
            // 
            this.policyTextBox.Location = new System.Drawing.Point(128, 83);
            this.policyTextBox.Name = "policyTextBox";
            this.policyTextBox.Size = new System.Drawing.Size(100, 20);
            this.policyTextBox.TabIndex = 9;
            this.policyTextBox.Visible = false;
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.Location = new System.Drawing.Point(128, 83);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(100, 20);
            this.specializationTextBox.TabIndex = 30;
            // 
            // specializationLabel
            // 
            this.specializationLabel.AutoSize = true;
            this.specializationLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializationLabel.Location = new System.Drawing.Point(23, 83);
            this.specializationLabel.Name = "specializationLabel";
            this.specializationLabel.Size = new System.Drawing.Size(101, 17);
            this.specializationLabel.TabIndex = 29;
            this.specializationLabel.Text = "Специализация";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(275, 146);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 47);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.serchButton_Click);
            // 
            // busyCheckBox
            // 
            this.busyCheckBox.AutoSize = true;
            this.busyCheckBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.busyCheckBox.Location = new System.Drawing.Point(568, 121);
            this.busyCheckBox.Name = "busyCheckBox";
            this.busyCheckBox.Size = new System.Drawing.Size(63, 21);
            this.busyCheckBox.TabIndex = 33;
            this.busyCheckBox.Text = "Занят";
            this.busyCheckBox.UseVisualStyleBackColor = true;
            // 
            // админToolStripMenuItem
            // 
            this.админToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.аыToolStripMenuItem,
            this.doctorToolStripMenuItem});
            this.админToolStripMenuItem.Name = "админToolStripMenuItem";
            this.админToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.админToolStripMenuItem.Text = "Режим";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patientToolStripMenuItem.Text = "Пациент";
            // 
            // аыToolStripMenuItem
            // 
            this.аыToolStripMenuItem.Name = "аыToolStripMenuItem";
            this.аыToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doctorToolStripMenuItem.Text = "Доктор";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.админToolStripMenuItem,
            this.админToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // админToolStripMenuItem1
            // 
            this.админToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.админToolStripMenuItem1.Name = "админToolStripMenuItem1";
            this.админToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.админToolStripMenuItem1.Text = "Админ";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addUserToolStripMenuItem.Text = "Добавить пользоватея";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.deleteUserToolStripMenuItem.Text = "Удалить пользователя";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.changePasswordToolStripMenuItem.Text = "Изменить пароль";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // addColumn
            // 
            this.addColumn.HeaderText = "Записать";
            this.addColumn.Name = "addColumn";
            this.addColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Отписать";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 382);
            this.Controls.Add(this.busyCheckBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.specializationTextBox);
            this.Controls.Add(this.specializationLabel);
            this.Controls.Add(this.policyTextBox);
            this.Controls.Add(this.policyLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toTimePicker2);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.scheduleDataGridView);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.doctorOrPatientComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 420);
            this.MinimumSize = new System.Drawing.Size(680, 420);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя страница";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doctorOrPatientComboBox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toTimePicker2;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label policyLabel;
        private System.Windows.Forms.TextBox policyTextBox;
        private System.Windows.Forms.TextBox specializationTextBox;
        private System.Windows.Forms.Label specializationLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox busyCheckBox;
        private System.Windows.Forms.ToolStripMenuItem админToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator аыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem админToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn addColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
    }
}