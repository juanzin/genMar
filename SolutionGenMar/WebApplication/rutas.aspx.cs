using BussinessLayer;
using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class rutas : System.Web.UI.Page
    {
        B_ruta ruta = new B_ruta();
        protected void Page_Load(object sender, EventArgs e)
        {
            buscarObjeto.Visible = false;
            GridMostrarData.Visible = false;
            agregarObjecto.Visible = false;
            eliminarObjeto.Visible = false;
        }

        public void OnClickMostrar(object sender, EventArgs e)
        {
            List<E_ruta> rutas = ruta.listaRutas();
            GridMostrarData.DataSource = rutas;
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

            string origen = inputOrigen.Text;
            string destino = inputDestino.Text;
            string fechallegada = inputFechaLlegada.Text;
            string fechasalida = inputFechaSalida.Text;
            string fechaRegistro = inputFechaRegistro.Text;
            string atiempo = inputATiempo.Text;
            string distancia = inputDistancia.Text;
            string idcamion = inputIdCamion.Text;
            string idchofer = inputIdChofer.Text;

            bool response = ruta.InsertaRuta(origen, destino, fechallegada, fechasalida, fechaRegistro, atiempo, distancia, idcamion, idchofer);

            if (response == false)
            {
                Console.WriteLine("error to save");
            }

        }

        public void OnClickEliminar(object sender, EventArgs e)
        {
            // capturar y eliminar
            string id = deleteRuta.Text;
            ruta.deleteRuta(id);

        }

        public void OnClickBuscar(object sender, EventArgs e)
        {
            // search to the database
            string id = inputBuscar.Text;
            E_ruta result = ruta.buscarRuta(id);
            List<E_ruta> listRutas = new List<E_ruta>();
            listRutas.Add(result);
            GridViewBuscar.DataSource = listRutas;
            GridViewBuscar.DataBind();
            buscarObjeto.Visible = true;

        }
    }
}