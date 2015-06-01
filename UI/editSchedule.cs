using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalClinic
{
    public partial class editSchedule : Form
    {
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
    }
}
