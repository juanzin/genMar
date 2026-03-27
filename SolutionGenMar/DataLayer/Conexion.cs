using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
// using Microsoft.Data.SqlClient;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Conexion
    {
        private static string UrlDatabase = "Server=(localdb)\\MSSQLLocalDB;Database=company;Trusted_Connection=True;";

        public static SqlConnection GetConnection() {
            SqlConnection conn = new SqlConnection(UrlDatabase);
            try {
                conn.Open();
                return conn;
            }
            catch(Exception e) {
                throw new Exception("Error to connect to the database: " + e.Message);
            }
        }

        public static bool testConection() {
            try {
                using (SqlConnection conn = GetConnection()) {
                    return conn.State == ConnectionState.Open;
                }
            }
            catch {
                return false;
            }
        }
    }
}
