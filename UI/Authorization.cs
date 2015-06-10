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
            if (Model.userExists(loginTextBox.Text, passwordTextBox.Text))
            {
                Main editSchedule = new Main(loginTextBox.Text);
                this.Hide();
                editSchedule.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль");
            }

            loginTextBox.Text = "";
            passwordTextBox.Text = ""; 
            this.Show();
            loginTextBox.Focus();
        }
    }
}