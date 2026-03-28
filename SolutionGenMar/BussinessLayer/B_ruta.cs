using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class B_ruta
    {

        D_Ruta DataRutas = new D_Ruta();
        public List<E_ruta> listaRutas()
        {
            List<E_ruta> rutas = new List<E_ruta>();
            rutas = DataRutas.ListarRutas();

            return rutas;
        }

        public bool InsertaRuta(string origen, string destino, string fechallegada, string fechasalida, string fechaRegistro,
            string atiempo, string distancia, string idcamion, string idchofer)
        {
            bool response = false;
            if (string.IsNullOrEmpty(origen)
                || string.IsNullOrEmpty(destino)
                || string.IsNullOrEmpty(fechallegada)
                || string.IsNullOrEmpty(fechasalida)
                || string.IsNullOrEmpty(fechaRegistro)
                || string.IsNullOrEmpty(atiempo)
                || string.IsNullOrEmpty(distancia)
                || string.IsNullOrEmpty(idcamion)
                || string.IsNullOrEmpty(idchofer))
            {
                response = false;
            }
            else
            {

                DataRutas.InsertaRuta(
                    new E_ruta
                    {
                        Origen = origen,
                        Destino = destino,
                        FechaLlegada = fechallegada,
                        FechaSalida = fechasalida,
                        FechaRegistro = fechaRegistro,
                        ATiempo = Convert.ToBoolean(atiempo),
                        Distancia = float.Parse(distancia),
                        IdCamion = Convert.ToInt32(idcamion),
                        IdChofer = Convert.ToInt32(idchofer)
                    }
                );
                response = true;
            }

            return response;
        }

        public bool deleteRuta(string idRuta)
        {
            bool response = false;

            if (string.IsNullOrEmpty(idRuta))
            {
                return response;
            }

            response = true;
            int id = Convert.ToInt32(idRuta);

            response = DataRutas.EliminarRuta(id);

            return response;

        }

        public E_ruta buscarRuta(string idRuta)
        {
            // bool response = false;
            E_ruta response;

            int id = Convert.ToInt32(idRuta);
            response = DataRutas.ObtenerRutaPorID(id);
            return response;

        }


    }
}
