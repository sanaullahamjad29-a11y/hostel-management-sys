using Microsoft.Data.SqlClient;
using System.Data;

namespace hostelmanagement.Database
{
    public class PaymentDB
    {
        public static void AddPayment(int id, string month)
        {
            using (SqlConnection conn = dbconfig.GetConnection())
            {
                conn.Open();

                string check =
                    @"SELECT COUNT(*)
                    FROM Payments
                    WHERE StudentID=@id
                    AND Month=@month";

                SqlCommand cmdCheck =
                    new SqlCommand(check, conn);

                cmdCheck.Parameters.AddWithValue("@id", id);
                cmdCheck.Parameters.AddWithValue("@month", month);

                int count =
                    (int)cmdCheck.ExecuteScalar();

                if (count > 0)
                    throw new Exception("Already Paid!");

                string query = @"
                INSERT INTO Payments
                (StudentID,Amount,Month,Status)

                VALUES
                (@id,4500,@month,'Paid')";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@month", month);

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetFeeStatus(string month)
        {
            using (SqlConnection conn = dbconfig.GetConnection())
            {
                string query = @"
                SELECT
                S.StudentID,
                S.FullName,
                S.RoomNumber,

                ISNULL(P.Status,'Pending')
                AS FeeStatus

                FROM Students S

                LEFT JOIN Payments P
                ON S.StudentID = P.StudentID
                AND P.Month=@month";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, conn);

                da.SelectCommand.Parameters
                    .AddWithValue("@month", month);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
