using hostelmanagement.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace hostelmanagement
{
    public partial class viewstudents : Form
    {
        public viewstudents()
        {
            InitializeComponent();
        }

        private void viewall_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Database se data table fetch karein
                DataTable dt = StudentDB.GetAllStudents();

                // 2. Structural Row Validation Check 
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvStudents.DataSource = dt;
                }
                else
                {
                    // Agar backend data store bilkul khali hai to custom message show karein
                    MessageBox.Show("Student table ledger is currently empty. Please register a student profile first to view records.",
                                    "No Data Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Unhandled data errors parsing block [cite: 397-398]
                MessageBox.Show("Data Retrieval Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Grid content handling operations goes here
        }
    }
}