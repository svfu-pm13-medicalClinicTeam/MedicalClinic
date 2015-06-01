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
    public partial class adminWindow : Form
    {
        public adminWindow()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUser addUser = new addUser();
            addUser.ShowDialog();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            deleteUser deleteUser = new deleteUser();
            deleteUser.ShowDialog();
        }
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            changePassword changePassword = new changePassword();
            changePassword.ShowDialog();
        }


    }
}
