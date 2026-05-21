using Microsoft.Data.SqlClient;
using hostelmanagement.Models;
using System.Data;

namespace hostelmanagement.Database
{
    public class RoomDB
    {
        public static void AddRoom(Room r)
        {
            using (SqlConnection conn = dbconfig.GetConnection())
            {
                string query =
                    @"INSERT INTO Rooms
                    (RoomNumber,HostelName,Capacity,CurrentOccupancy)

                    VALUES
                    (@rno,@hostel,4,0)";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@rno", r.RoomNumber);
                cmd.Parameters.AddWithValue("@hostel", r.HostelName);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllRooms()
        {
            using (SqlConnection conn = dbconfig.GetConnection())
            {
                string query = @"
                SELECT RoomNumber,
                HostelName,
                Capacity,
                CurrentOccupancy,

                CASE
                    WHEN CurrentOccupancy >= 4
                    THEN 'Full'
                    ELSE 'Available'
                END AS RoomStatus

                FROM Rooms";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}