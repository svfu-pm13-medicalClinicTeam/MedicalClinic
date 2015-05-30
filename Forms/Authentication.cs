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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (Model.userExists(loginBox.Text, passwordBox.Text))
            {
                this.Hide();
                if (loginBox.Text != "admin")
                {
                    MainUser mainUser = new MainUser();
                    mainUser.ShowDialog();
                }
                else
                {
                    MainAdmin mainAdmin = new MainAdmin();
                    mainAdmin.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Неправильные логин или пароль");
            }
        }
    }
}
