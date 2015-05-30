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
    public partial class Autointefication : Form
    {
        public Autointefication()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataManipulator.getUserByName(loginBox.Text).HPWD);
            if (Model.userExists(loginBox.Text, passwordBox.Text))
            {
                if (loginBox.Text != "admin")
                {
                    MainUser mainUser = new MainUser();
                    mainUser.Show();
                    this.Hide();
                }
                else
                {
                    MainAdmin mainAdmin = new MainAdmin();
                    mainAdmin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("error password");
            }
        }
    }
}
