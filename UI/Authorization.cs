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
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "" && passwordTextBox.Text != "" && 
                Model.userExists(loginTextBox.Text, passwordTextBox.Text))
            {
                this.Hide();
                if (loginTextBox.Text != "admin")
                {
                    userWindow userWindow = new userWindow();
                    userWindow.ShowDialog();
                }
                else
                {
                    adminWindow AdminWindow = new adminWindow();
                    AdminWindow.ShowDialog();
                }
                if (remainInTheSystemCheckBox.Checked == false)
                {
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
                this.Show();
                loginTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль");
            }

        }
    }
}