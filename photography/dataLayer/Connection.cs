// using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataLayer
{
    public class Connection
    {
        private static string urlDatabase = "Server=BLUE;Database=photography;Trusted_Connection=True;";

        public static SqlConnection GetConnection() {

            SqlConnection conn = new SqlConnection(urlDatabase);

            try { 
                conn.Open();
                return conn;
            } catch (Exception ex){
                throw new Exception("Error to connect to the database: ", ex);
            
            }
        }
    }
}
