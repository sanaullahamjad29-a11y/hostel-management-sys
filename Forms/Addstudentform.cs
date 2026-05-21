using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using hostelmanagement.Database; // dbconfig linkage
using hostelmanagement.Models;   // Student model structure

namespace hostelmanagement
{
    public partial class Addstudentform : Form
    {
        public Addstudentform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Basic Fields Validation
            if (txtName.Text.Trim() == "" || txtCNIC.Text.Trim() == "" || txtRoomNo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = dbconfig.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 2. CORE LOGIC: Check if ANY rooms exist in the database 
                    string countRoomsQuery = "SELECT COUNT(*) FROM Rooms";
                    SqlCommand countRoomsCmd = new SqlCommand(countRoomsQuery, conn);
                    int totalRooms = (int)countRoomsCmd.ExecuteScalar();

                    if (totalRooms == 0)
                    {
                        // Structural warning prompt if system contains 0 room configurations
                        MessageBox.Show("No rooms found in the database system.",
                                        "Rooms Configuration Missing",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                    // 3. Room Occupancy Threshold Check
                    string checkOccupancyQuery = "SELECT CurrentOccupancy FROM Rooms WHERE RoomNumber = @rno";
                    SqlCommand checkOccCmd = new SqlCommand(checkOccupancyQuery, conn);
                    checkOccCmd.Parameters.AddWithValue("@rno", txtRoomNo.Text.Trim());

                    object result = checkOccCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("The specified Room Number does not exist. Please enter a valid room registered in the system.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int currentOccupancy = Convert.ToInt32(result);
                    if (currentOccupancy >= 4)
                    {
                        MessageBox.Show("Allocation Rejected: Target room has reached its maximum capacity of 4 students.", "Capacity Violation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // 4. Safe Database Transaction Execution
                    Student newStudent = new Student();
                    newStudent.FullName = txtName.Text.Trim();
                    newStudent.CNIC = txtCNIC.Text.Trim();
                    newStudent.RoomNumber = Convert.ToInt32(txtRoomNo.Text.Trim());

                    StudentDB.AddStudent(newStudent);

                    MessageBox.Show("Student Added Successfully to Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fields Reset Workspace
                    txtName.Clear();
                    txtCNIC.Clear();
                    txtRoomNo.Clear();
                    txtName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Operation Failure: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}