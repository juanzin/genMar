using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class E_camion
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public int Tipo { get; set; }
        public int Modelo { get; set; }
        public string Marca { get; set; }
        public double Kilometraje { get; set; }
        public bool Disponibilidad { get; set; }
        public string UrlFoto { get; set; }

    }
}
