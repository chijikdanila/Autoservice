using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoservice.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void forgetLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Свяжитесь с админом по номеру +375292281337!", "Забыли пароль?", MessageBoxButtons.OK);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //User currentUser;

            //foreach (var user in users)
            //{
            //    if (usernameTextBox.Text == user.Login && passwordTextBox.Text == user.Password)
            //    {
            //        currentUser = user;
            //        break;
            //    }
            //}

            //if (currentUser == null)
            //{
            //    Some logic like
            //    MessageBox.Show("Incorrect user", "Warning!", MessageBoxButton.OK);
            //}
            
        }

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTextBox.Text = string.Empty;
        }

        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            passwordTextBox.Text = string.Empty;
        }
    }
}
