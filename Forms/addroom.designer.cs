namespace hostelmanagement
{
    partial class addroom
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

            textBox1 = new TextBox();

            label2 = new Label();

            textBox2 = new TextBox();

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
                new Size(900, 550);

            StartPosition =
                FormStartPosition.CenterScreen;

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Text = "Add Room";

            // PANEL

            panel1.BackColor =
                Color.White;

            panel1.Size =
                new Size(600, 400);

            panel1.Location =
                new Point(150, 70);

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
                new Point(170, 30);

            labelTitle.Text =
                "ADD ROOM";

            // ROOM LABEL

            label1.AutoSize = true;

            label1.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            label1.ForeColor =
                Color.FromArgb(71, 85, 105);

            label1.Location =
                new Point(70, 120);

            label1.Text =
                "Room Number";

            // ROOM TEXTBOX

            textBox1.Font =
                new Font(
                    "Segoe UI",
                    12F);

            textBox1.Location =
                new Point(70, 160);

            textBox1.Size =
                new Size(450, 34);

            // HOSTEL LABEL

            label2.AutoSize = true;

            label2.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            label2.ForeColor =
                Color.FromArgb(71, 85, 105);

            label2.Location =
                new Point(70, 230);

            label2.Text =
                "Hostel Name";

            // HOSTEL TEXTBOX

            textBox2.Font =
                new Font(
                    "Segoe UI",
                    12F);

            textBox2.Location =
                new Point(70, 270);

            textBox2.Size =
                new Size(450, 34);

            // BUTTON

            button1.Text =
                "ADD ROOM";

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
                new Point(180, 340);

            button1.Size =
                new Size(220, 50);

            button1.Click +=
                button1_Click;

            // ADD CONTROLS

            panel1.Controls.Add(labelTitle);

            panel1.Controls.Add(label1);

            panel1.Controls.Add(textBox1);

            panel1.Controls.Add(label2);

            panel1.Controls.Add(textBox2);

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

        private TextBox textBox1;

        private Label label2;

        private TextBox textBox2;

        private Button button1;
    }
}