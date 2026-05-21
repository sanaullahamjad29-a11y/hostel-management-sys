using System;
using System.Drawing;
using System.Windows.Forms;
using hostelmanagement.Database; // StudentDB class ke liye zaroori hai

namespace hostelmanagement
{
    public partial class deletestd : Form
    {
        public deletestd()
        {
            InitializeComponent();
            AddHoverEffects();
        }

        private void AddHoverEffects()
        {
            buttondlt.MouseEnter += ButtonHover;
            buttondlt.MouseLeave += ButtonLeave;
        }

        private void ButtonHover(object sender, EventArgs e)
        {
            buttondlt.BackColor = Color.DarkRed;
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            buttondlt.BackColor = Color.FromArgb(220, 38, 38);
        }

        // =========================
        // DELETE BUTTON (UPDATED)
        // =========================
        private void buttondlt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Student ID", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student from database?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int studentId = Convert.ToInt32(textBox1.Text.Trim());

                    // ACTUAL DATABASE CALL (Yeh line missing thi!)
                    StudentDB.DeleteStudent(studentId);

                    MessageBox.Show("Student Deleted Successfully from Database!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Clear();
                    textBox1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}