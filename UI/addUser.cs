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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text != "" && passwordTextBox.Text != "")
            {
                Model.addUser(userTextBox.Text, passwordTextBox.Text);
                MessageBox.Show("Пользователь успешно добавлен");
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля");
            }
        }
    }
}
