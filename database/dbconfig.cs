using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace hostelmanagement.Database
{
    public static class dbconfig
    {
        private static string _connString = string.Empty;

       
        /// Pure Server-Based Connection String.
       
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connString))
                {
                    // Local machine standard instance configurations 
                    string serverInstance = @".\SQLEXPRESS";
                    string databaseName = "HostelDB";

                    // Standard Direct Connection String without explicit AttachDbFilename conflicts
                    _connString = $"Server={serverInstance};Database={databaseName};Trusted_Connection=True;TrustServerCertificate=True;";
                }
                return _connString;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return conn.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }

        public static long GetDatabaseFileSize()
        {
            string sizeQuery = "SELECT size * 8 * 1024 FROM sys.master_files WHERE DB_NAME(database_id) = 'HostelDB' AND type = 0";

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sizeQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt64(result);
                        }
                    }
                }
                catch
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}