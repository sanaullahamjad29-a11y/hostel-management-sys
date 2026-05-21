using System;
using System.Windows.Forms;

namespace hostelmanagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            string password = txtPassword.Text.Trim();

            if (username == "admin" &&
                password == "admin123")
            {
                MessageBox.Show(
                    "Login Successful",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dashboard dashboard = new dashboard();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username or Password",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();

                txtPassword.Focus();
            }
        }

        private void chkShowPassword_CheckedChanged(
            object sender,
            EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }
    }
}