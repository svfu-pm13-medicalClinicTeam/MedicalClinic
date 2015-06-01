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
    public partial class registration : Form
    {
        public registration()
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
                snilsLabel.Visible = true;
                snilsTextBox.Visible = true;
                innLabel.Visible = true;
                innTextBox.Visible = true;
                specializationLabel.Visible = true;
                specializationTextBox.Visible = true;
                categoryLabel.Visible = true;
                categoryTextBox.Visible = true;
            }
            else
            {
                policyLabel.Visible = true;
                policyTextBox.Visible = true;
                snilsLabel.Visible = false;
                snilsTextBox.Visible = false;
                innLabel.Visible = false;
                innTextBox.Visible = false;
                specializationLabel.Visible = false;
                specializationTextBox.Visible = false;
                categoryLabel.Visible = false;
                categoryTextBox.Visible = false;
            }

        }
    }
}
