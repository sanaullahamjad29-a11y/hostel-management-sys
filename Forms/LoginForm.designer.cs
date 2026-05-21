namespace hostelmanagement
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();

            this.lblProject = new System.Windows.Forms.Label();

            this.lblSubtitle = new System.Windows.Forms.Label();

            this.rightPanel = new System.Windows.Forms.Panel();

            this.lblLogin = new System.Windows.Forms.Label();

            this.lblUsername = new System.Windows.Forms.Label();

            this.lblPassword = new System.Windows.Forms.Label();

            this.txtUsername = new System.Windows.Forms.TextBox();

            this.txtPassword = new System.Windows.Forms.TextBox();

            this.chkShowPassword = new System.Windows.Forms.CheckBox();

            this.btnLogin = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // FORM

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1000, 550);

            this.BackColor =
                System.Drawing.Color.White;

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Hostel Management Login";

            // LEFT PANEL

            this.leftPanel.BackColor =
                System.Drawing.Color.FromArgb(30, 41, 59);

            this.leftPanel.Location =
                new System.Drawing.Point(0, 0);

            this.leftPanel.Size =
                new System.Drawing.Size(450, 550);

            // PROJECT LABEL

            this.lblProject.Text =
                "HOSTEL\nMANAGEMENT\nSYSTEM";

            this.lblProject.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    28F,
                    System.Drawing.FontStyle.Bold);

            this.lblProject.ForeColor =
                System.Drawing.Color.White;

            this.lblProject.AutoSize = true;

            this.lblProject.Location =
                new System.Drawing.Point(60, 150);

            // SUBTITLE

            this.lblSubtitle.Text =
                "Modern Hostel Administration";

            this.lblSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F);

            this.lblSubtitle.ForeColor =
                System.Drawing.Color.Gainsboro;

            this.lblSubtitle.AutoSize = true;

            this.lblSubtitle.Location =
                new System.Drawing.Point(65, 320);

            // RIGHT PANEL

            this.rightPanel.BackColor =
                System.Drawing.Color.White;

            this.rightPanel.Location =
                new System.Drawing.Point(450, 0);

            this.rightPanel.Size =
                new System.Drawing.Size(550, 550);

            // LOGIN TITLE

            this.lblLogin.Text = "LOGIN";

            this.lblLogin.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblLogin.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);

            this.lblLogin.AutoSize = true;

            this.lblLogin.Location =
                new System.Drawing.Point(170, 80);

            // USERNAME LABEL

            this.lblUsername.Text = "Username";

            this.lblUsername.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            this.lblUsername.ForeColor =
                System.Drawing.Color.Black;

            this.lblUsername.AutoSize = true;

            this.lblUsername.Location =
                new System.Drawing.Point(80, 180);

            // USERNAME TEXTBOX

            this.txtUsername.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F);

            this.txtUsername.Location =
                new System.Drawing.Point(80, 215);

            this.txtUsername.Size =
                new System.Drawing.Size(300, 34);

            // PASSWORD LABEL

            this.lblPassword.Text = "Password";

            this.lblPassword.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            this.lblPassword.ForeColor =
                System.Drawing.Color.Black;

            this.lblPassword.AutoSize = true;

            this.lblPassword.Location =
                new System.Drawing.Point(80, 290);

            // PASSWORD TEXTBOX

            this.txtPassword.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F);

            this.txtPassword.Location =
                new System.Drawing.Point(80, 325);

            this.txtPassword.Size =
                new System.Drawing.Size(300, 34);

            this.txtPassword.UseSystemPasswordChar = true;

            // SHOW PASSWORD

            this.chkShowPassword.Text =
                "Show Password";

            this.chkShowPassword.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.chkShowPassword.AutoSize = true;

            this.chkShowPassword.Location =
                new System.Drawing.Point(80, 370);

            this.chkShowPassword.CheckedChanged +=
                new System.EventHandler(
                    this.chkShowPassword_CheckedChanged);

            // LOGIN BUTTON

            this.btnLogin.Text = "LOGIN";

            this.btnLogin.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.btnLogin.ForeColor =
                System.Drawing.Color.White;

            this.btnLogin.BackColor =
                System.Drawing.Color.FromArgb(59, 130, 246);

            this.btnLogin.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLogin.FlatAppearance.BorderSize = 0;

            this.btnLogin.Location =
                new System.Drawing.Point(80, 430);

            this.btnLogin.Size =
                new System.Drawing.Size(300, 50);

            this.btnLogin.Click +=
                new System.EventHandler(this.btnLogin_Click);

            // ADD CONTROLS TO LEFT PANEL

            this.leftPanel.Controls.Add(this.lblProject);

            this.leftPanel.Controls.Add(this.lblSubtitle);

            // ADD CONTROLS TO RIGHT PANEL

            this.rightPanel.Controls.Add(this.lblLogin);

            this.rightPanel.Controls.Add(this.lblUsername);

            this.rightPanel.Controls.Add(this.lblPassword);

            this.rightPanel.Controls.Add(this.txtUsername);

            this.rightPanel.Controls.Add(this.txtPassword);

            this.rightPanel.Controls.Add(this.chkShowPassword);

            this.rightPanel.Controls.Add(this.btnLogin);

            // ADD PANELS TO FORM

            this.Controls.Add(this.leftPanel);

            this.Controls.Add(this.rightPanel);

            this.ResumeLayout(false);

            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;

        private System.Windows.Forms.Panel rightPanel;

        private System.Windows.Forms.Label lblProject;

        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Label lblLogin;

        private System.Windows.Forms.Label lblUsername;

        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.CheckBox chkShowPassword;

        private System.Windows.Forms.Button btnLogin;
    }
}