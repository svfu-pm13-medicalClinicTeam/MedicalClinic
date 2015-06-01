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
    public partial class userWindow : Form
    {
        public userWindow()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            registration.ShowDialog();
        }

        private void editSchedule_Click(object sender, EventArgs e)
        {
            editSchedule editSchedule = new editSchedule();
            editSchedule.ShowDialog();
        }
    }
}
