using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class B_chofer
    {
        D_Chofer dataChofer;
        public B_chofer() { 
            dataChofer = new D_Chofer();
        }
        public List<E_Chofer> DisplayChofer()
        {
            List<E_Chofer> choferes = new List<E_Chofer>();
            dataChofer = new D_Chofer();
            choferes = dataChofer.GetChoferes();

            return choferes;
        }

        public bool InsertaChofer(string nombre, string paterno, string materno, string licencia, string telefono, string disponibilidad)
        {
            bool response = false;
            int newDisponibilidad = 0;
            if (string.IsNullOrEmpty(nombre) 
                || string.IsNullOrEmpty(materno)
                || string.IsNullOrEmpty(paterno)
                || string.IsNullOrEmpty(licencia)
                || string.IsNullOrEmpty(telefono)) {
                response = false;
            } else {
                
                //if (Convert.ToBoolean(disponibilidad)) {
                //    newDisponibilidad = 1;
                //}
                dataChofer.InsertaChofer(
                    new E_Chofer { 
                        Nombre = nombre,
                        ApellidoPaterno = paterno,
                        ApellidoMaterno = materno,
                        Licencia = licencia,
                        Telefono = telefono,
                        Disponibilidad = newDisponibilidad
                    }
                );
                response = true;
            }

            return response;
        }
    }
}
