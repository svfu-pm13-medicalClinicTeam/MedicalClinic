namespace MedicalClinic
{
    partial class editSchedule
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
            this.fioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorOrPatientComboBox
            // 
            this.doctorOrPatientComboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorOrPatientComboBox.FormattingEnabled = true;
            this.doctorOrPatientComboBox.Items.AddRange(new object[] {
            "Доктор",
            "Пациент"});
            this.doctorOrPatientComboBox.Location = new System.Drawing.Point(115, 10);
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
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Выберите";
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.scheduleDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioColumn,
            this.cabinetColumn,
            this.dateColumn,
            this.timeColumn,
            this.policyColumn,
            this.busyColumn,
            this.addColumn,
            this.deleteColumn});
            this.scheduleDataGridView.Location = new System.Drawing.Point(12, 154);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.RowHeadersWidth = 30;
            this.scheduleDataGridView.Size = new System.Drawing.Size(717, 198);
            this.scheduleDataGridView.TabIndex = 3;
            // 
            // fioColumn
            // 
            this.fioColumn.HeaderText = "ФИО";
            this.fioColumn.MinimumWidth = 15;
            this.fioColumn.Name = "fioColumn";
            this.fioColumn.Width = 130;
            // 
            // cabinetColumn
            // 
            this.cabinetColumn.HeaderText = "Кабинет";
            this.cabinetColumn.Name = "cabinetColumn";
            this.cabinetColumn.Width = 60;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Дата приема";
            this.dateColumn.Name = "dateColumn";
            // 
            // timeColumn
            // 
            this.timeColumn.HeaderText = "Время приема";
            this.timeColumn.Name = "timeColumn";
            // 
            // policyColumn
            // 
            this.policyColumn.HeaderText = "Полис";
            this.policyColumn.Name = "policyColumn";
            // 
            // busyColumn
            // 
            this.busyColumn.HeaderText = "Занят";
            this.busyColumn.Name = "busyColumn";
            this.busyColumn.Width = 60;
            // 
            // addColumn
            // 
            this.addColumn.HeaderText = "Добавить";
            this.addColumn.Name = "addColumn";
            this.addColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addColumn.Width = 60;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Удалить";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Width = 60;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(373, 10);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 4;
            // 
            // toTimePicker2
            // 
            this.toTimePicker2.Location = new System.Drawing.Point(373, 50);
            this.toTimePicker2.Name = "toTimePicker2";
            this.toTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.toTimePicker2.TabIndex = 5;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromLabel.Location = new System.Drawing.Point(303, 10);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(18, 17);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "C";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLabel.Location = new System.Drawing.Point(303, 50);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(26, 17);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "По";
            // 
            // policyLabel
            // 
            this.policyLabel.AutoSize = true;
            this.policyLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.policyLabel.Location = new System.Drawing.Point(10, 50);
            this.policyLabel.Name = "policyLabel";
            this.policyLabel.Size = new System.Drawing.Size(47, 17);
            this.policyLabel.TabIndex = 8;
            this.policyLabel.Text = "Полис";
            this.policyLabel.Visible = false;
            // 
            // policyTextBox
            // 
            this.policyTextBox.Location = new System.Drawing.Point(115, 50);
            this.policyTextBox.Name = "policyTextBox";
            this.policyTextBox.Size = new System.Drawing.Size(100, 20);
            this.policyTextBox.TabIndex = 9;
            this.policyTextBox.Visible = false;
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.Location = new System.Drawing.Point(115, 50);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(100, 20);
            this.specializationTextBox.TabIndex = 30;
            // 
            // specializationLabel
            // 
            this.specializationLabel.AutoSize = true;
            this.specializationLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializationLabel.Location = new System.Drawing.Point(10, 50);
            this.specializationLabel.Name = "specializationLabel";
            this.specializationLabel.Size = new System.Drawing.Size(101, 17);
            this.specializationLabel.TabIndex = 29;
            this.specializationLabel.Text = "Специализация";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(318, 91);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 35);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // busyCheckBox
            // 
            this.busyCheckBox.AutoSize = true;
            this.busyCheckBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.busyCheckBox.Location = new System.Drawing.Point(530, 91);
            this.busyCheckBox.Name = "busyCheckBox";
            this.busyCheckBox.Size = new System.Drawing.Size(63, 21);
            this.busyCheckBox.TabIndex = 33;
            this.busyCheckBox.Text = "Занят";
            this.busyCheckBox.UseVisualStyleBackColor = true;
            // 
            // editSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 364);
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
            this.Name = "editSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить расписание";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn fioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busyColumn;
        private System.Windows.Forms.DataGridViewButtonColumn addColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.CheckBox busyCheckBox;
    }
}