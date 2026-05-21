namespace hostelmanagement
{
    partial class deletestd
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

            stdid = new Label();

            textBox1 = new TextBox();

            buttondlt = new Button();

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
                new Size(850, 500);

            StartPosition =
                FormStartPosition.CenterScreen;

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Text = "Delete Student";

            // PANEL

            panel1.BackColor =
                Color.White;

            panel1.Location =
                new Point(130, 60);

            panel1.Size =
                new Size(580, 330);

            // TITLE

            labelTitle.AutoSize = true;

            labelTitle.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            labelTitle.ForeColor =
                Color.FromArgb(220, 38, 38);

            labelTitle.Location =
                new Point(150, 30);

            labelTitle.Text =
                "DELETE STUDENT";

            // LABEL

            stdid.AutoSize = true;

            stdid.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            stdid.ForeColor =
                Color.FromArgb(71, 85, 105);

            stdid.Location =
                new Point(70, 130);

            stdid.Text =
                "Student ID";

            // TEXTBOX

            textBox1.Font =
                new Font(
                    "Segoe UI",
                    12F);

            textBox1.Location =
                new Point(70, 170);

            textBox1.Size =
                new Size(430, 34);

            // BUTTON

            buttondlt.Text =
                "DELETE";

            buttondlt.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            buttondlt.ForeColor =
                Color.White;

            buttondlt.BackColor =
                Color.FromArgb(220, 38, 38);

            buttondlt.FlatStyle =
                FlatStyle.Flat;

            buttondlt.FlatAppearance.BorderSize = 0;

            buttondlt.Location =
                new Point(180, 240);

            buttondlt.Size =
                new Size(200, 50);

            buttondlt.Click +=
                buttondlt_Click;


            // ADD CONTROLS

            panel1.Controls.Add(labelTitle);

            panel1.Controls.Add(stdid);

            panel1.Controls.Add(textBox1);

            panel1.Controls.Add(buttondlt);

            Controls.Add(panel1);

            panel1.ResumeLayout(false);

            panel1.PerformLayout();

            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;

        private Label labelTitle;

        private Label stdid;

        private TextBox textBox1;

        private Button buttondlt;
    }
}