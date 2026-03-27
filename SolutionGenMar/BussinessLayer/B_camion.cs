using EntityLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class B_camion
    {
        public List<E_camion> DisplayCamiones() { 
            List<E_camion> camiones = new List<E_camion>();
            var DataCamion = new D_Camion();
            camiones = DataCamion.ListarCamiones();

            return camiones;
        }
    }
}
