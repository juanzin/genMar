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

        public List<E_ruta> listaRutas()
        {
            List<E_ruta> rutas = new List<E_ruta>();
            var DataChofer = new D_Ruta();
            rutas = DataChofer.ListarRutas();

            return rutas;
        }
    }
}
