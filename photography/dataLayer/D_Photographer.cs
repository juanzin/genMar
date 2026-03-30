using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataLayer
{
    public class D_Photographer
    {

        public bool UpdateInfo(E_Photographer photographer) { 
            bool response = false;


            using (SqlConnection conn = Connection.GetConnection()) {
                SqlCommand cmd = new SqlCommand("SP_Update_Photographer", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", 1);
                cmd.Parameters.AddWithValue("@Username", photographer.Username);
                cmd.Parameters.AddWithValue("@Password", photographer.Password);
                cmd.Parameters.AddWithValue("@Instagram", photographer.Instagram);
                cmd.Parameters.AddWithValue("@Facebook", photographer.Facebook);
                cmd.Parameters.AddWithValue("@Email", photographer.Email);
                cmd.Parameters.AddWithValue("@Biography", photographer.Biography);

                response = cmd.ExecuteNonQuery() > 0;
            }

            return response;
        }
    }
}
