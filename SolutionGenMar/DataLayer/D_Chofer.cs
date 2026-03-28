using EntityLayer;
// using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class D_Chofer
    {

        public List<E_Chofer> GetChoferes(bool? disponibilidad = null) {
            List<E_Chofer> lista = new List<E_Chofer>();

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Chofer", conn);
                cmd.CommandType = CommandType.Text;

                if (disponibilidad.HasValue)
                {
                    cmd.Parameters.AddWithValue("@disponibilidad", disponibilidad.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@disponibilidad", DBNull.Value);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new E_Chofer
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        ApellidoPaterno = reader["ApellidoPaterno"].ToString(),
                        ApellidoMaterno = reader["ApellidoMaterno"].ToString(),
                        Licencia = reader["Licencia"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Disponibilidad = Convert.ToInt32(reader["Disponibilidad"]),
                    });
                }
                ;

                return lista;

            }
        }

        public bool InsertaChofer(E_Chofer chofer)
        {

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_Insert_chofer", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nombre", chofer.Nombre);
                command.Parameters.AddWithValue("@ApellidoPaterno", chofer.ApellidoPaterno);
                command.Parameters.AddWithValue("@ApellidoMaterno", chofer.ApellidoMaterno);
                command.Parameters.AddWithValue("@Licencia", chofer.Licencia);
                command.Parameters.AddWithValue("@Telefono", chofer.Telefono);
                command.Parameters.AddWithValue("@Disponibilidad", chofer.Disponibilidad);

                return command.ExecuteNonQuery() > 0;
            }
        }
        public bool ActualizarChofer(E_Chofer chofer) {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_Update_Chofer", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", chofer.Id);
                
                command.Parameters.AddWithValue("@Disponibilidad", chofer.Disponibilidad);

                return command.ExecuteNonQuery() > 0;
            }

        }

        public bool EliminarChofer(int Id)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_Delete_chofer", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdChofer", Id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public E_Chofer ObtenerChoferPorID(int choferId)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Chofer where Id = @choferId", conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@choferId", choferId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new E_Chofer
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        ApellidoPaterno = reader["ApellidoPaterno"].ToString(),
                        ApellidoMaterno = reader["ApellidoPaterno"].ToString(),
                        Licencia = reader["Licencia"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Disponibilidad = Convert.ToInt32(reader["Disponibilidad"]),
                    };
                }
                else
                {
                    return null;

                }

            }

        }



        public bool ExisteLicencia(string licencia) { // TODO
            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("ExisteLicencia", conn); // TODO
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Licencia", licencia);

                int resultado = Convert.ToInt32(command.ExecuteScalar());
                
                return resultado > 0;
            }

        }
    }
}
