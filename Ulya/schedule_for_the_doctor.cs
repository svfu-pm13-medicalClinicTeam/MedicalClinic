using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace medclin
{
    public partial class schedule_for_the_doctor : Form
    {
        public schedule_for_the_doctor()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(new object[] { "1 категории", "2 категории", "3 категории" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "терапевт", "хирург", "стоматолог", "невролог", "психиатр", "педиатр" });
        }

        private void schedule_for_the_doctor_Load(object sender, EventArgs e)
        {

        }
    }
}
