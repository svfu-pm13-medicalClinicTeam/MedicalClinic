﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace MedicalClinic
{
    public partial class editSchedule : Form
    {
        BindingSource bindingSource1 = new BindingSource();

        public editSchedule()
        {
            InitializeComponent();
            doctorOrPatientComboBox.SelectedIndex = 0;
        }

        private void doctorOrPatientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorOrPatientComboBox.SelectedItem == "Доктор")
            {
                policyLabel.Visible = false;
                policyTextBox.Visible = false;
                specializationLabel.Visible = true;
                specializationTextBox.Visible = true;
            }
            else
            {
                policyLabel.Visible = true;
                policyTextBox.Visible = true;
                specializationLabel.Visible = false;
                specializationTextBox.Visible = false;
            }
        }

        private void dataGridViewRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // нумерация строк в столбце-заголовке
            if (scheduleDataGridView.Rows[e.RowIndex].HeaderCell.Value == null
                || !scheduleDataGridView.Rows[e.RowIndex].HeaderCell.Value.Equals((e.RowIndex + 1).ToString()))
                scheduleDataGridView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
            // ну и так далее...
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //List<Schedule> schedule = Model.getSchedule(specializationTextBox.Text, fromDateTimePicker.Value.Date.ToString(),
              //                                          toTimePicker2.Value.Date.ToString(), busyCheckBox.Checked.ToString());
            scheduleDataGridView.DataSource = bindingSource1;
            Model.getData(bindingSource1, scheduleDataGridView, specializationTextBox.Text,
                          fromDateTimePicker.Value.ToShortDateString(), toTimePicker2.Value.ToShortDateString(),
                          busyCheckBox.Checked.ToString());
        }

        private void scheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumn = 2;
            int cabinetColumn = 5;
            int patientColumn = 6;

            MessageBox.Show(Convert.ToString(scheduleDataGridView.Rows[e.RowIndex].Cells[idColumn].Value));

            if (e.ColumnIndex == 0)
            {
                Model.addAppointment(Convert.ToInt32(scheduleDataGridView.Rows[e.RowIndex].Cells[idColumn].Value), 1, 1);
            }
            else
            {
                Model.clearAppointment(Convert.ToInt32(scheduleDataGridView.Rows[e.RowIndex].Cells[idColumn].Value));
            }
        }

        private void editSchedule_Load(object sender, EventArgs e)
        {
            scheduleDataGridView.DataSource = bindingSource1;
            DateTime fromDate = DateTime.Today;
            DateTime toDate = DateTime.Today.AddDays(7);
            Model.getData(bindingSource1, scheduleDataGridView, "",
                          fromDate.ToShortDateString(), toDate.ToShortDateString(), "");
        }
    }
}
