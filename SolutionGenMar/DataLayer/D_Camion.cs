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
    public class D_Camion
    {
        public List<E_camion> ListarCamiones(bool? disponibilidad = null)
        {
            List<E_camion> lista = new List<E_camion>();

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Camion", conn);
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
                    lista.Add(new E_camion
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Matricula = reader["Matricula"].ToString(),
                        Tipo = Convert.ToInt32(reader["Tipo"]),
                        Modelo = Convert.ToInt32(reader["Modelo"]),
                        Marca = reader["Marca"].ToString(),
                        Kilometraje = Convert.ToDouble(reader["Kilometraje"]),
                        Disponibilidad = Convert.ToBoolean(reader["Disponibilidad"]),
                        UrlFoto = reader["UrlFoto"].ToString()
                    });
                }
                ;

                return lista;
            }
        }


        public bool InsertaCamion(E_camion camion)
        {

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_insert_camion", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Matricula", camion.Matricula);
                command.Parameters.AddWithValue("@Tipo", camion.Tipo);
                command.Parameters.AddWithValue("@Modelo", camion.Modelo);
                command.Parameters.AddWithValue("@Marca", camion.Marca);
                command.Parameters.AddWithValue("@Kilometraje", camion.Kilometraje);
                command.Parameters.AddWithValue("@Disponibilidad", camion.Disponibilidad);
                command.Parameters.AddWithValue("@urlFoto", camion.UrlFoto);
                
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ActualizaCamion(EntityLayer.E_camion camion)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_update_camion", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdCamion", camion.Id);
                command.Parameters.AddWithValue("@Matricula", camion.Matricula);
                command.Parameters.AddWithValue("@Tipo", camion.Tipo);
                command.Parameters.AddWithValue("@Modelo", camion.Modelo);
                command.Parameters.AddWithValue("@Marca", camion.Marca);
                command.Parameters.AddWithValue("@Kilometraje", camion.Kilometraje);
                command.Parameters.AddWithValue("@Disponibilidad", camion.Disponibilidad);
                command.Parameters.AddWithValue("@UrlFoto", camion.UrlFoto);

                return command.ExecuteNonQuery() > 0;
            }

        }


        public bool EliminarCamion(int Id)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_Delete_Camion", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdCamion", Id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ExisteMatricula(string matricula)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("existe_matricula", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Matricula", matricula);

                int resultado = Convert.ToInt32(command.ExecuteScalar());

                return resultado > 0;

            }
        }

        public E_camion ObtenerCamionPorID(int camionId)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Camion where Id = @camionId", conn); // TODO
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@camionId", camionId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new E_camion
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Matricula = reader["Matricula"].ToString(),
                        Tipo = Convert.ToInt32(reader["Tipo"]),
                        Modelo = Convert.ToInt32(reader["Modelo"]),
                        Marca = reader["Marca"].ToString(),
                        Kilometraje = Convert.ToDouble(reader["Kilometraje"]),
                        Disponibilidad = Convert.ToBoolean(reader["Disponibilidad"]),
                        UrlFoto = reader["UrlFoto"].ToString()
                    };
                } else {
                    return null;
                
                }

            }

        }
    }
}
