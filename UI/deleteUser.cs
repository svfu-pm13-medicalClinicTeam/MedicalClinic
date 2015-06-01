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
    public partial class deleteUser : Form
    {
        public deleteUser()
        {
            InitializeComponent();
        }

        private void deleUserButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text != "")
            {
                Model.deleteUser(userTextBox.Text);
            }
            else
            {
                MessageBox.Show("Не заполнено поле");
            }
        }
    }
}
