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
    public partial class camiones : System.Web.UI.Page
    {
        private B_camion camion = new B_camion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                // CargaCamiones();
                buscarObjeto.Visible = false;
                GridMostrarCamiones.Visible = false;
                agregarObjecto.Visible = false;
                eliminarObjeto.Visible = false;
            }
        }

        /* private void CargaCamiones() {
            try {
                bool? disponibilidad = null;
                //if (ddlFiltro.SelectedValue == "1") {
                //    disponibilidad = true;
                //}
                //else
                //{
                //    if (ddlFiltro.SelectedValue == "2") {
                //        disponibilidad = false;
                    
                //    }
                //}

                List<E_camion> lista = camionData.DisplayCamiones(); // agregar disponibilidad

                // asignar a gridview
                //gvCamiones.DataSource = lista;
                //gvCamiones.DataBind();
                if (lista == null || lista.Count == 0)
                {
                    MostrarMensaje("No se encontraron camiones con el filtro seleccionado", "info");
                }
                else {
                    pnlMensaje.Visible = true;
                }
            } catch (Exception e) {
                MostrarMensaje("Error al cargar camiones: " + e.Message, "Error");
            }
        } */

        public void OnClickMostrar(object sender, EventArgs e) {
            // CargaCamiones();
            List<E_camion> camiones = camion.DisplayCamiones();
            GridMostrarCamiones.DataSource = camiones;
            GridMostrarCamiones.DataBind();

            buscarObjeto.Visible = false;
            GridMostrarCamiones.Visible = true;
            agregarObjecto.Visible = false;
            eliminarObjeto.Visible = false;

        }

        public void OnClickAgregar(object sender, EventArgs e) {
            //ddlFiltro.SelectedIndex = 0;
            //CargaCamiones();
            buscarObjeto.Visible = false;
            GridMostrarCamiones.Visible = false;
            agregarObjecto.Visible = true;
            eliminarObjeto.Visible = false;

            string matricula = inputMatricula.Text;
            string tipo = inputTipo.Text;
            string modelo = inputModelo.Text;
            string marca = inputMarca.Text;
            string kilometraje = inputKilometraje.Text;
            string urlFoto = inputUrlFoto.Text;

            camion.InsertaCamion(matricula, tipo, modelo, marca, kilometraje, urlFoto);

        }

        public void OnClickEliminar(object sender, EventArgs e) {
            //pnlMensaje.Visible = true;
            //lblMensaje.Text = mensaje;
            //pnlMensaje.CssClass = "info-mensaje " + tipo;
            buscarObjeto.Visible = false;
            GridMostrarCamiones.Visible = false;
            agregarObjecto.Visible = false;
            eliminarObjeto.Visible = true;

        }

        public void OnClickBuscar(object sender, EventArgs e)
        {
            //ddlFiltro.SelectedIndex = 0;
            //CargaCamiones();
            buscarObjeto.Visible = true;
            GridMostrarCamiones.Visible = false;
            agregarObjecto.Visible = false;
            eliminarObjeto.Visible=false;
        }

        public void OnClickGuardar(object sender, EventArgs e)
        {
            //ddlFiltro.SelectedIndex = 0;
            //CargaCamiones();
            
        }
    }
}