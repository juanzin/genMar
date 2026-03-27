using BussinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class choferes : System.Web.UI.Page
    {
        B_chofer chofer = new B_chofer();
        protected void Page_Load(object sender, EventArgs e)
        {
            buscarObjeto.Visible = false;
            GridMostrarData.Visible = false;
            agregarObjecto.Visible = false;
            eliminarObjeto.Visible = false;

        }

        public void OnClickMostrar(object sender, EventArgs e)
        {
            // CargaCamiones();
            List<E_Chofer> choferes = chofer.DisplayChofer();
            GridMostrarData.DataSource = choferes;
            GridMostrarData.DataBind();

            buscarObjeto.Visible = false;
            GridMostrarData.Visible = true;
            agregarObjecto.Visible = false;
            eliminarObjeto.Visible = false;

        }

        public void OnClickAgregar(object sender, EventArgs e)
        {
            /// SOLO OCULTA VISTAS
            //ddlFiltro.SelectedIndex = 0;
            //CargaCamiones();
            buscarObjeto.Visible = false;
            GridMostrarData.Visible = false;
            agregarObjecto.Visible = true;
            eliminarObjeto.Visible = false;

        }

        public void OnClickEliminarOption(object sender, EventArgs e)
        {
            //pnlMensaje.Visible = true;
            //lblMensaje.Text = mensaje;
            //pnlMensaje.CssClass = "info-mensaje " + tipo;
            buscarObjeto.Visible = false;
            GridMostrarData.Visible = false;
            agregarObjecto.Visible = false;
            eliminarObjeto.Visible = true;

        }

        public void OnClickBuscarOption(object sender, EventArgs e)
        {
            //ddlFiltro.SelectedIndex = 0;
            //CargaCamiones();
            buscarObjeto.Visible = true;
            GridMostrarData.Visible = false;
            agregarObjecto.Visible = false;
            eliminarObjeto.Visible = false;
        }

        public void OnClickGuardar(object sender, EventArgs e)
        {
            // capturar datos y guardar

            string nombre = inputNombre.Text;
            string materno = inputApellidoMaterno.Text;
            string paterno = inputApellidoPaterno.Text;
            string licencia = inputLicencia.Text;
            string telefono = inputTelefono.Text;
            string disponibilidad = inputDisponibilidad.Text;

            chofer.InsertaChofer(nombre, materno, paterno, licencia, telefono, disponibilidad);

        }

        public void OnClickEliminar(object sender, EventArgs e)
        {
            // capturar y eliminar
            string id = deleteChofer.Text;
            // chofer.deleteChofer(id);

        }

        public void OnClickBuscar(object sender, EventArgs e)
        {
            string id = inputBuscar.Text;
            // E_camion result = chofer.buscarCamion(id);
            List<E_camion> listCamions = new List<E_camion>();
            // listCamions.Add(result);
            // GridViewBuscar.DataSource = listCamions;
            GridViewBuscar.DataBind();

        }
    }
}