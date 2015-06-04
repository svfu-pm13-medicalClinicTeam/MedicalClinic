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
            this.doctorOrPatientComboBox.Location = new System.Drawing.Point(153, 12);
            this.doctorOrPatientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.doctorOrPatientComboBox.Name = "doctorOrPatientComboBox";
            this.doctorOrPatientComboBox.Size = new System.Drawing.Size(132, 29);
            this.doctorOrPatientComboBox.TabIndex = 0;
            this.doctorOrPatientComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorOrPatientComboBox_SelectedIndexChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectLabel.Location = new System.Drawing.Point(13, 12);
            this.selectLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(89, 21);
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
            this.scheduleDataGridView.Location = new System.Drawing.Point(16, 190);
            this.scheduleDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.RowHeadersWidth = 30;
            this.scheduleDataGridView.Size = new System.Drawing.Size(956, 244);
            this.scheduleDataGridView.TabIndex = 3;
            this.scheduleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleDataGridView_CellContentClick);
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
            this.fromDateTimePicker.Location = new System.Drawing.Point(497, 12);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.fromDateTimePicker.TabIndex = 4;
            // 
            // toTimePicker2
            // 
            this.toTimePicker2.Location = new System.Drawing.Point(497, 62);
            this.toTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.toTimePicker2.Name = "toTimePicker2";
            this.toTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.toTimePicker2.TabIndex = 5;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromLabel.Location = new System.Drawing.Point(404, 12);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(23, 21);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "C";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLabel.Location = new System.Drawing.Point(404, 62);
            this.toLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(33, 21);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "По";
            // 
            // policyLabel
            // 
            this.policyLabel.AutoSize = true;
            this.policyLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.policyLabel.Location = new System.Drawing.Point(13, 62);
            this.policyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.policyLabel.Name = "policyLabel";
            this.policyLabel.Size = new System.Drawing.Size(61, 21);
            this.policyLabel.TabIndex = 8;
            this.policyLabel.Text = "Полис";
            this.policyLabel.Visible = false;
            // 
            // policyTextBox
            // 
            this.policyTextBox.Location = new System.Drawing.Point(153, 62);
            this.policyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.policyTextBox.Name = "policyTextBox";
            this.policyTextBox.Size = new System.Drawing.Size(132, 22);
            this.policyTextBox.TabIndex = 9;
            this.policyTextBox.Visible = false;
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.Location = new System.Drawing.Point(153, 62);
            this.specializationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(132, 22);
            this.specializationTextBox.TabIndex = 30;
            // 
            // specializationLabel
            // 
            this.specializationLabel.AutoSize = true;
            this.specializationLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializationLabel.Location = new System.Drawing.Point(13, 62);
            this.specializationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specializationLabel.Name = "specializationLabel";
            this.specializationLabel.Size = new System.Drawing.Size(133, 21);
            this.specializationLabel.TabIndex = 29;
            this.specializationLabel.Text = "Специализация";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(424, 112);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 43);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // busyCheckBox
            // 
            this.busyCheckBox.AutoSize = true;
            this.busyCheckBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.busyCheckBox.Location = new System.Drawing.Point(707, 112);
            this.busyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.busyCheckBox.Name = "busyCheckBox";
            this.busyCheckBox.Size = new System.Drawing.Size(77, 25);
            this.busyCheckBox.TabIndex = 33;
            this.busyCheckBox.Text = "Занят";
            this.busyCheckBox.UseVisualStyleBackColor = true;
            // 
            // editSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 448);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckBox busyCheckBox;
        private System.Windows.Forms.DataGridViewButtonColumn addColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
    }
}