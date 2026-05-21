using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // SQL Client namespace driver configuration
using hostelmanagement.Database; // dbconfig layer connectivity mapping

namespace hostelmanagement
{
    public partial class enterfee : Form
    {
        public enterfee()
        {
            InitializeComponent();
            AddHoverEffects();
        }

        // =========================
        // HOVER EFFECT
        // =========================
        private void AddHoverEffects()
        {
            btnUpdate.MouseEnter += ButtonHover;
            btnUpdate.MouseLeave += ButtonLeave;
        }

        private void ButtonHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(30, 100, 160);
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
        }

        // =========================
        // UPDATE BUTTON (MUKAMMAL RELATIONAL DATABASE INTEGRATION)
        // =========================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Data Validation Check
            if (txtStudentID.Text.Trim() == "" || txtMonth.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int studentId = Convert.ToInt32(txtStudentID.Text.Trim());
                string selectedMonth = txtMonth.Text.Trim();

                // 2. Database call using your exact PaymentDB class methods!
                PaymentDB.AddPayment(studentId, selectedMonth);

                // 3. SUCCESS TRANSACTION FEEDBACK
                MessageBox.Show("Fee Updated & Logged Successfully inside Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear and Reset View Workspace Elements
                txtStudentID.Clear();
                txtMonth.Clear();
                txtStudentID.Focus();
            }
            catch (Exception ex)
            {
                // Agar pehle se paid hoga ya koi aur error hoga to yahan catch ho jaye ga
                MessageBox.Show("Transaction Alert: " + ex.Message, "Database Response", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}