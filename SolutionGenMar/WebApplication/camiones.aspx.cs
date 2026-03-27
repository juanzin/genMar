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
        private B_camion camionData = new B_camion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                CargaCamiones();
            }
        }

        private void CargaCamiones() {
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
        }

        protected void btnFiltrar_Click(object sender, EventArgs e) {
            CargaCamiones();
        }

        protected void btnActualizar_Click(object sender, EventArgs e) {
            ddlFiltro.SelectedIndex = 0;
            CargaCamiones();
        }

        private void MostrarMensaje(string mensaje, string tipo) {
            pnlMensaje.Visible = true;
            lblMensaje.Text = mensaje;
            pnlMensaje.CssClass = "info-mensaje " + tipo;
        }
    }
}