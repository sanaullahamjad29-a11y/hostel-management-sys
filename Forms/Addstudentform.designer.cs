namespace hostelmanagement
{
    partial class Addstudentform
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();

            labelTitle = new Label();

            label1 = new Label();

            txtName = new TextBox();

            label2 = new Label();

            txtCNIC = new TextBox();

            label3 = new Label();

            txtRoomNo = new TextBox();

            button1 = new Button();

            panel1.SuspendLayout();

            SuspendLayout();

            // FORM

            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(241, 245, 249);

            ClientSize =
                new Size(900, 600);

            StartPosition =
                FormStartPosition.CenterScreen;

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Text = "Add Student";

            // PANEL

            panel1.BackColor =
                Color.White;

            panel1.Location =
                new Point(130, 50);

            panel1.Size =
                new Size(650, 500);

            // TITLE

            labelTitle.AutoSize = true;

            labelTitle.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            labelTitle.ForeColor =
                Color.FromArgb(30, 41, 59);

            labelTitle.Location =
                new Point(180, 30);

            labelTitle.Text =
                "ADD STUDENT";

            // FULL NAME LABEL

            label1.AutoSize = true;

            label1.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            label1.ForeColor =
                Color.FromArgb(71, 85, 105);

            label1.Location =
                new Point(70, 130);

            label1.Text =
                "Full Name";

            // NAME TEXTBOX

            txtName.Font =
                new Font(
                    "Segoe UI",
                    12F);

            txtName.Location =
                new Point(70, 170);

            txtName.Size =
                new Size(500, 34);

            // CNIC LABEL

            label2.AutoSize = true;

            label2.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            label2.ForeColor =
                Color.FromArgb(71, 85, 105);

            label2.Location =
                new Point(70, 240);

            label2.Text =
                "CNIC";

            // CNIC TEXTBOX

            txtCNIC.Font =
                new Font(
                    "Segoe UI",
                    12F);

            txtCNIC.Location =
                new Point(70, 280);

            txtCNIC.Size =
                new Size(500, 34);

            // ROOM LABEL

            label3.AutoSize = true;

            label3.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            label3.ForeColor =
                Color.FromArgb(71, 85, 105);

            label3.Location =
                new Point(70, 350);

            label3.Text =
                "Room Number";

            // ROOM TEXTBOX

            txtRoomNo.Font =
                new Font(
                    "Segoe UI",
                    12F);

            txtRoomNo.Location =
                new Point(70, 390);

            txtRoomNo.Size =
                new Size(500, 34);

            // SAVE BUTTON

            button1.Text =
                "SAVE STUDENT";

            button1.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            button1.ForeColor =
                Color.White;

            button1.BackColor =
                Color.FromArgb(59, 130, 246);

            button1.FlatStyle =
                FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0;

            button1.Location =
                new Point(220, 440);

            button1.Size =
                new Size(220, 50);

            button1.Click +=
                button1_Click;


            // ADD CONTROLS

            panel1.Controls.Add(labelTitle);

            panel1.Controls.Add(label1);

            panel1.Controls.Add(txtName);

            panel1.Controls.Add(label2);

            panel1.Controls.Add(txtCNIC);

            panel1.Controls.Add(label3);

            panel1.Controls.Add(txtRoomNo);

            panel1.Controls.Add(button1);

            Controls.Add(panel1);

            panel1.ResumeLayout(false);

            panel1.PerformLayout();

            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;

        private Label labelTitle;

        private Label label1;

        private TextBox txtName;

        private Label label2;

        private TextBox txtCNIC;

        private Label label3;

        private TextBox txtRoomNo;

        private Button button1;
    }
}