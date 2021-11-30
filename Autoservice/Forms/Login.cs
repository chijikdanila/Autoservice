using DatabaseLayer.Entities;
using DatabaseLayer;
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
        List<User> users;
        
        public Login()
        {
            InitializeComponent();
            users = DefaultOperations.GetUsers();
        }

        private void forgetLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Свяжитесь с админом по номеру +375292281337!", "Забыли пароль?", MessageBoxButtons.OK);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User currentUser = null;
            currentUser = DefaultOperations.getUser(usernameTextBox.Text, passwordTextBox.Text);

            //foreach (var user in users)
            //{
            //    if (usernameTextBox.Text == user.NickName && passwordTextBox.Text == user.Pass)
            //    {
            //        currentUser = user;
            //        break;
            //    }
            //}

            if (currentUser is null)
            {
                //Some logic like
                MessageBox.Show("Incorrect user", "Warning!", MessageBoxButtons.OK);
            }
            else if (currentUser.User_Type)
            {
                //Open menu form
                Menu menuForm = new Menu(currentUser, this.Close);
                menuForm.Show();
                this.Hide();
            }
            else
            {
                //Open registry form
                Registry registryForm = new Registry(currentUser, this.Close);
                registryForm.Show();
                this.Hide();
            }

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
