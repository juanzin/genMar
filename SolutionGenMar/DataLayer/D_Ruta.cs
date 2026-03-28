using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class D_Ruta
    {
        public List<E_ruta> ListarRutas()
        {
            List<E_ruta> lista = new List<E_ruta>();

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ruta", conn);
                cmd.CommandType = CommandType.Text;

     

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new E_ruta
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Origen = reader["Origen"].ToString(),
                        Destino = reader["Destino"].ToString(),
                        FechaSalida = reader["FechaSalida"].ToString(),
                        FechaLlegada = reader["FechaLlegada"].ToString(),
                        FechaRegistro = reader["FechaRegistro"].ToString(),
                        ATiempo = Convert.ToBoolean(reader["ATiempo"]),
                        Distancia = (float) Convert.ToDouble(reader["Distancia"]),
                        IdCamion = Convert.ToInt32(reader["IdCamion"]),
                        IdChofer = Convert.ToInt32(reader["IdChofer"])
                    });
                }
                ;

                return lista;
            }
        }

        public bool InsertaRuta(E_ruta ruta)
        {

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_insert_ruta", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Origen", ruta.Origen);
                command.Parameters.AddWithValue("@Destino", ruta.Destino);
                command.Parameters.AddWithValue("@FechaSalida", ruta.FechaSalida);
                command.Parameters.AddWithValue("@FechaLlegada", ruta.FechaLlegada);
                command.Parameters.AddWithValue("@FechaRegistro", ruta.FechaRegistro);
                command.Parameters.AddWithValue("@ATiempo", ruta.ATiempo);
                command.Parameters.AddWithValue("@Distancia", ruta.Distancia);
                command.Parameters.AddWithValue("@IdCamion", ruta.IdCamion);
                command.Parameters.AddWithValue("@IdChofer", ruta.IdChofer);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ActualizaRuta(EntityLayer.E_ruta ruta)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_Update_Ruta", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", ruta.Id);
                command.Parameters.AddWithValue("@Destino", ruta.Destino);
                command.Parameters.AddWithValue("@FechaSalida", ruta.FechaSalida);
                command.Parameters.AddWithValue("@FechaLlegada", ruta.FechaLlegada);
                command.Parameters.AddWithValue("@FechaRegistro", ruta.FechaRegistro);
                command.Parameters.AddWithValue("@ATiempo", ruta.ATiempo);
                command.Parameters.AddWithValue("@Distancia", ruta.Distancia);
                command.Parameters.AddWithValue("@IdCamion", ruta.IdCamion);
                command.Parameters.AddWithValue("@IdChofer", ruta.IdChofer);

                return command.ExecuteNonQuery() > 0;
            }

        }

        public bool EliminarRuta(int Id)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SP_Delete_Ruta", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public E_ruta ObtenerRutaPorID(int rutaId)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Ruta where Id = @rutaId", conn); // TODO
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@rutaId", rutaId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new E_ruta
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Origen = reader["Origen"].ToString(),
                        Destino = reader["Destino"].ToString(),
                        FechaSalida = reader["FechaSalida"].ToString(),
                        FechaLlegada = reader["FechaLlegada"].ToString(),
                        FechaRegistro = reader["FechaRegistro"].ToString(),
                        ATiempo = Convert.ToBoolean(reader["ATiempo"]),
                        Distancia = (float)Convert.ToDouble(reader["Distancia"]),
                        IdCamion = Convert.ToInt32(reader["IdCamion"]),
                        IdChofer = Convert.ToInt32(reader["IdChofer"])
                    };
                }
                else
                {
                    return null;

                }

            }

        }

    }
}
