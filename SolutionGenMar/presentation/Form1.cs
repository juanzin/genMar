using BussinessLayer;
using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// get projects
            //B_camion camion= new B_camion();
            //var camiones = camion.DisplayCamiones();

            //Console.WriteLine(camiones);
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get camiones
            panel2.Visible = false;
            panel1.Visible = true;
            label1.Text = "Lista camiones";
            B_camion camion = new B_camion();
            var camiones = camion.DisplayCamiones();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Matricula",
                HeaderText = "Matricula",
                DataPropertyName = "Matricula"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                HeaderText = "Tipo",
                DataPropertyName = "Tipo"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Modelo",
                HeaderText = "Modelo",
                DataPropertyName = "Modelo"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Marca",
                HeaderText = "Marca",
                DataPropertyName = "Marca"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Disponibilidad",
                HeaderText = "Disponibilidad",
                DataPropertyName = "Disponibilidad"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Kilometraje",
                HeaderText = "Kilometraje",
                DataPropertyName = "Kilometraje"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UrlFoto",
                HeaderText = "UrlFoto",
                DataPropertyName = "UrlFoto"
            });


            //dataGridView1.Columns[0].DataPropertyName = "Matricula";
            //dataGridView1.Columns[1].DataPropertyName = "Tipo";
            //dataGridView1.Columns[2].DataPropertyName = "Modelo";
            //dataGridView1.Columns[3].DataPropertyName = "Marca";
            //dataGridView1.Columns[4].DataPropertyName = "Disponibilidad";
            //dataGridView1.Columns[5].DataPropertyName = "Kilometraje";
            //dataGridView1.Columns[6].DataPropertyName = "UrlFoto";
            dataGridView1.DataSource = camiones;
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mostrar todos las rutas
            panel2.Visible = false;
            panel1.Visible = true;
            label1.Text = "Lista rutas";
            B_ruta ruta = new B_ruta();
            var rutas = ruta.listaRutas();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Origen",
                HeaderText = "Origen",
                DataPropertyName = "Origen"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Destino",
                HeaderText = "Destino",
                DataPropertyName = "Destino"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaSalida",
                HeaderText = "FechaSalida",
                DataPropertyName = "FechaSalida"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaLlegada",
                HeaderText = "FechaLlegada",
                DataPropertyName = "FechaLlegada"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaRegistro",
                HeaderText = "FechaRegistro",
                DataPropertyName = "FechaRegistro"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ATiempo",
                HeaderText = "ATiempo",
                DataPropertyName = "ATiempo"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Distancia",
                HeaderText = "Distancia",
                DataPropertyName = "Distancia"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdCamion",
                HeaderText = "IdCamion",
                DataPropertyName = "IdCamion"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdChofer",
                HeaderText = "IdChofer",
                DataPropertyName = "IdChofer"
            });


            //dataGridView1.Columns[0].DataPropertyName = "Id";
            //dataGridView1.Columns[1].DataPropertyName = "Origen";
            //dataGridView1.Columns[2].DataPropertyName = "Destino";
            //dataGridView1.Columns[3].DataPropertyName = "FechaSalida";
            //dataGridView1.Columns[4].DataPropertyName = "FechaLlegada";
            //dataGridView1.Columns[5].DataPropertyName = "FechaRegistro";
            //dataGridView1.Columns[6].DataPropertyName = "ATiempo";
            //dataGridView1.Columns[6].DataPropertyName = "Distancia";
            //dataGridView1.Columns[6].DataPropertyName = "IdCamion";
            //dataGridView1.Columns[6].DataPropertyName = "IdChofer";
            dataGridView1.DataSource = rutas;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mostrarTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // mostrar todos los choferes
            panel2.Visible = false;
            panel1.Visible = true;
            label1.Text = "Lista choferes";
            B_chofer chofer = new B_chofer();
            var choferes = chofer.DisplayChofer();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ApellidoPaterno",
                HeaderText = "ApellidoPaterno",
                DataPropertyName = "ApellidoPaterno"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ApellidoMaterno",
                HeaderText = "ApellidoMaterno",
                DataPropertyName = "ApellidoMaterno"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Licencia",
                HeaderText = "Licencia",
                DataPropertyName = "Licencia"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Telefono",
                HeaderText = "Telefono",
                DataPropertyName = "Telefono"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Disponibilidad",
                HeaderText = "Disponibilidad",
                DataPropertyName = "Disponibilidad"
            });


            //dataGridView1.Columns[0].DataPropertyName = "Nombre";
            //dataGridView1.Columns[1].DataPropertyName = "ApellidoPaterno";
            //dataGridView1.Columns[2].DataPropertyName = "ApellidoMaterno";
            //dataGridView1.Columns[3].DataPropertyName = "Licencia";
            //dataGridView1.Columns[4].DataPropertyName = "Telefono";
            //dataGridView1.Columns[5].DataPropertyName = "Disponibilidad";
            dataGridView1.DataSource = choferes;
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
