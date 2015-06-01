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
            if (doctorOrPatientComboBox.TabIndex == 0)
            {
                policyLabel.Visible = false;
                policyTextBox.Visible = false;
                phoneLabel.Visible = false;
                phoneTextBox.Visible = false;
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
                phoneLabel.Visible = true;
                phoneTextBox.Visible = true;
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
