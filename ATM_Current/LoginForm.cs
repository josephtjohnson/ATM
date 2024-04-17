using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = textBoxUsername;

        }

        private void login_Click(object sender, EventArgs e) 
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            //insert code to connect to database and verify username and password
            //return the customer object

            if (string.IsNullOrEmpty(username)) 
            {
                MessageBox.Show("Please enter a username");
            }

            else if (string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Please enter a password");
            }

            //else if username or password is incorrect request the correct information

            else 
            {
                //ATMFORM form = new ATMForm(customer);
                ATMForm form = new ATMForm();
                this.Visible = false;
                form.ShowDialog();
            }
        }

        private void exit_click (object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}
