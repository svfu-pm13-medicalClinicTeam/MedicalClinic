using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinicWraps;

namespace MedicalClinic
{
    public partial class Main : Form
    {
        BindingSource bindingSource;
        string login;

        public Main(string _login)
        {
            InitializeComponent();
            login = _login;
            bindingSource = new BindingSource();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (login == "admin")
            {
                adminToolStripMenuItem.Visible = true;
            }
            else
            {
                adminToolStripMenuItem.Visible = false;
            }

            showWeekTable();
            Model.getSpecializations(specializationComboBox);
        }

        private void showWeekTable()
        {
            Model.getTimeTable(bindingSource, scheduleDataGridView, "", DateTime.Today.ToShortDateString(),
                               DateTime.Today.AddDays(7).ToShortDateString(), "");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Model.getTimeTable(bindingSource, scheduleDataGridView, Convert.ToString(specializationComboBox.SelectedIndex + 1),
                               fromDateTimePicker.Value.ToShortDateString(),
                               toTimePicker2.Value.ToShortDateString(), busyCheckBox.Checked.ToString());
        }

        private void scheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumn = 2;
            int cabinetColumn = 5;
            int patientColumn = 6;

            if (e.ColumnIndex == 0)
            {
                PatientWindow patientWindow = new PatientWindow(Convert.ToInt32(scheduleDataGridView.Rows[e.RowIndex].Cells[idColumn].Value));
                this.Hide();
                patientWindow.ShowDialog();
                this.Show();
            }
            else
            {
                Model.clearAppointment(Convert.ToInt32(scheduleDataGridView.Rows[e.RowIndex].Cells[idColumn].Value));
            }
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientWindow patientWindow = new PatientWindow();
            this.Hide();
            patientWindow.ShowDialog();
            this.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPatient patientAdd = new addPatient();
        }
    }
}
