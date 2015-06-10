using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic
{
    public partial class PatientWindow : Form
    {
        int scheduleId;
        BindingSource bindingSource;
        string gender = "";

        public PatientWindow()
        {
            scheduleId = 0;
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        public PatientWindow(int _scheduleId)
        {
            scheduleId = _scheduleId;
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            Model.getPatientTable(bindingSource, patientDataGridView, nameTextBox.Text, patronymicTextBox.Text,
                                  surnameTextBox.Text, passwordTextBox.Text, dateOfBirth.Text, 
                                  policyTextBox.Text, phoneTextBox.Text, gender);
        }

        private void manRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "м";
        }

        private void womanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "ж";
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumn = 2;
            if (e.ColumnIndex == 0 && scheduleId > 0)
            {
                Model.addAppointment(scheduleId, Convert.ToInt32(patientDataGridView.Rows[e.RowIndex].Cells[idColumn].Value));
            }
            else if (e.ColumnIndex == 0 && scheduleId == 0)
            {
 
            }
        }

        private void PatientWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
