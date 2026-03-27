using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class B_camion
    {
        D_Camion DataCamion;
        public B_camion() {
            DataCamion = new D_Camion();
        }
        public List<E_camion> DisplayCamiones() { 
            List<E_camion> camiones = new List<E_camion>();
        
            camiones = DataCamion.ListarCamiones();

            return camiones;
        }

        public bool InsertaCamion(string matricula, string tipo, string modelo, string marca, string kilometraje, string urlFoto)
        {
            bool response = false;
            if (string.IsNullOrEmpty(matricula)
                || string.IsNullOrEmpty(tipo)
                || string.IsNullOrEmpty(modelo)
                || string.IsNullOrEmpty(marca)
                || string.IsNullOrEmpty(kilometraje)
                || string.IsNullOrEmpty(urlFoto))
            {
                response = false;
            }
            else
            {

                DataCamion.InsertaCamion(
                    new E_camion
                    {
                        Matricula = matricula,
                        Tipo = Convert.ToInt32(tipo),
                        Modelo = Convert.ToInt32(modelo),
                        Marca = marca,
                        Kilometraje = Convert.ToDouble(kilometraje),
                        UrlFoto = urlFoto,
                        Disponibilidad = true
                    }
                );
                response = true;
            }

            return response;
        }
    }
}
