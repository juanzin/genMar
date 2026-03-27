using BussinessLayer;
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
    public partial class Form2 : Form
    {
        B_chofer chofer;
        public Form2()
        {
            InitializeComponent();
            chofer = new B_chofer();
            label7.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// guardar
            string nombre;
            string paterno;
            string materno;
            string licencia;
            string telefono;
            bool disponibilidad;

            label7.Visible = false;

            nombre = textBox1.Text;
            paterno = textBox2.Text;
            materno = textBox3.Text;
            licencia = textBox3.Text;
            telefono = textBox5.Text;
            disponibilidad = checkBox1.Checked;

            bool response = this.chofer.InsertaChofer(nombre, paterno, materno, licencia, telefono, disponibilidad);
            if (response == false)
            {
                label7.Text = "Error in server. Try again";
                label7.Visible = true;
            }
            else { 
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /// cancel, only close
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
