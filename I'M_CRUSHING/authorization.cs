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
        bool admin = false;

        private void enterButton_Click(object sender, EventArgs e)
        {
            if ((loginTextBox.Text == "admin") && (passwordTextBox.Text == "admin"))
            {
                Main editSchedule = new Main();
                admin = true;
                editSchedule.ShowDialog();
            }
            else if ((loginTextBox.Text == "user") && (passwordTextBox.Text == "user"))
            {
                Main editSchedule = new Main();
                admin = false;
                editSchedule.ShowDialog();

            }
            else MessageBox.Show("Неверные логин или пароль");
            loginTextBox.Text = "";
            passwordTextBox.Text = ""; 
            this.Show();
            loginTextBox.Focus();
        }
    }
}