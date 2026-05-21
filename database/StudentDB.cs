using Microsoft.Data.SqlClient;
using hostelmanagement.Models;
using System.Data;

namespace hostelmanagement.Database
{
    public class StudentDB
    {
        public static void AddStudent(Student s)
        {
            using (SqlConnection conn = dbconfig.GetConnection())
            {
                conn.Open();

                string checkQuery =
                    "SELECT CurrentOccupancy FROM Rooms WHERE RoomNumber=@rno";

                SqlCommand cmdCheck =
                    new SqlCommand(checkQuery, conn);

                cmdCheck.Parameters.AddWithValue("@rno", s.RoomNumber);

                object result = cmdCheck.ExecuteScalar();

                if (result == null)
                    throw new Exception("Room does not exist!");

                int current = Convert.ToInt32(result);

                if (current >= 4)
                    throw new Exception("Room Full!");

                string query = @"
                    INSERT INTO Students
                    (FullName,CNIC,RoomNumber)

                    VALUES
                    (@name,@cnic,@rno);

                    UPDATE Rooms
                    SET CurrentOccupancy =
                    CurrentOccupancy + 1
                    WHERE RoomNumber=@rno";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", s.FullName);
                cmd.Parameters.AddWithValue("@cnic", s.CNIC);
                cmd.Parameters.AddWithValue("@rno", s.RoomNumber);

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllStudents()
        {
            using (SqlConnection conn = dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Students";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public static void DeleteStudent(int id)
        {
            using (SqlConnection conn = dbconfig.GetConnection())
            {
                conn.Open();

                string getRoom =
                    "SELECT RoomNumber FROM Students WHERE StudentID=@id";

                SqlCommand cmdGet =
                    new SqlCommand(getRoom, conn);

                cmdGet.Parameters.AddWithValue("@id", id);

                object roomObj = cmdGet.ExecuteScalar();

                if (roomObj == null)
                    throw new Exception("Student not found!");

                int roomNo = Convert.ToInt32(roomObj);

                string query = @"
                    DELETE FROM Students
                    WHERE StudentID=@id;

                    UPDATE Rooms
                    SET CurrentOccupancy =
                    CurrentOccupancy - 1
                    WHERE RoomNumber=@rno";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@rno", roomNo);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
