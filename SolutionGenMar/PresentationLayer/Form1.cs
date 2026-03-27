using BussinessLayer;
using EntityLayer;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get camiones
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // obtener lista
            //try
            //{
                B_camion camion = new B_camion();
                List<E_camion> camiones = new List<E_camion>();
                camiones = camion.DisplayCamiones();
                Console.WriteLine();
            //}
            //catch { 
            
            //}
        }
    }
}
