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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (oldPasswordTextBox.Text != "" && newPasswordTextBox.Text != "")
            {
                Model.changeAdminPassword(oldPasswordTextBox.Text, newPasswordTextBox.Text);
                MessageBox.Show("Пароль успешно изменен");
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля");
            }
        }
    }
}
