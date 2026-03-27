using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class E_ruta
    {
        public int Id { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaSalida { get; set; }
        public string FechaLlegada { get; set; }
	    public string FechaRegistro { get; set; }
        public bool ATiempo { get; set; }
        public float Distancia { get; set; }
        public int IdCamion { get; set; }
        public int IdChofer { get; set; }
    }
}
