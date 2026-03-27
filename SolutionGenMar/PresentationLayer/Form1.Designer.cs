namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            camionesToolStripMenuItem = new ToolStripMenuItem();
            choferesToolStripMenuItem = new ToolStripMenuItem();
            rutasToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            insertarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            obtenerCamionToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Matricula = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Disponibilidad = new DataGridViewTextBoxColumn();
            Kilometraje = new DataGridViewTextBoxColumn();
            Urlfoto = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { camionesToolStripMenuItem, choferesToolStripMenuItem, rutasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // camionesToolStripMenuItem
            // 
            camionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarToolStripMenuItem, insertarToolStripMenuItem, eliminarToolStripMenuItem, obtenerCamionToolStripMenuItem });
            camionesToolStripMenuItem.Name = "camionesToolStripMenuItem";
            camionesToolStripMenuItem.Size = new Size(88, 24);
            camionesToolStripMenuItem.Text = "Camiones";
            // 
            // choferesToolStripMenuItem
            // 
            choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            choferesToolStripMenuItem.Size = new Size(81, 24);
            choferesToolStripMenuItem.Text = "Choferes";
            // 
            // rutasToolStripMenuItem
            // 
            rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            rutasToolStripMenuItem.Size = new Size(59, 24);
            rutasToolStripMenuItem.Text = "Rutas";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(224, 26);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // insertarToolStripMenuItem
            // 
            insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            insertarToolStripMenuItem.Size = new Size(224, 26);
            insertarToolStripMenuItem.Text = "Insertar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(224, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // obtenerCamionToolStripMenuItem
            // 
            obtenerCamionToolStripMenuItem.Name = "obtenerCamionToolStripMenuItem";
            obtenerCamionToolStripMenuItem.Size = new Size(224, 26);
            obtenerCamionToolStripMenuItem.Text = "Obtener Camion";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(43, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 379);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 41);
            label1.TabIndex = 0;
            label1.Text = "Lista de camiones";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Matricula, Modelo, Tipo, Marca, Disponibilidad, Kilometraje, Urlfoto });
            dataGridView1.Location = new Point(60, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(603, 273);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Matricula
            // 
            Matricula.HeaderText = "Matricula";
            Matricula.MinimumWidth = 6;
            Matricula.Name = "Matricula";
            Matricula.ReadOnly = true;
            Matricula.Width = 125;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 6;
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            Modelo.Width = 125;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 125;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marcas";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 125;
            // 
            // Disponibilidad
            // 
            Disponibilidad.HeaderText = "Disponibilidad";
            Disponibilidad.MinimumWidth = 6;
            Disponibilidad.Name = "Disponibilidad";
            Disponibilidad.ReadOnly = true;
            Disponibilidad.Width = 125;
            // 
            // Kilometraje
            // 
            Kilometraje.HeaderText = "Kilometraje";
            Kilometraje.MinimumWidth = 6;
            Kilometraje.Name = "Kilometraje";
            Kilometraje.ReadOnly = true;
            Kilometraje.Width = 125;
            // 
            // Urlfoto
            // 
            Urlfoto.HeaderText = "Url foto";
            Urlfoto.MinimumWidth = 6;
            Urlfoto.Name = "Urlfoto";
            Urlfoto.ReadOnly = true;
            Urlfoto.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem camionesToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem obtenerCamionToolStripMenuItem;
        private ToolStripMenuItem choferesToolStripMenuItem;
        private ToolStripMenuItem rutasToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Disponibilidad;
        private DataGridViewTextBoxColumn Kilometraje;
        private DataGridViewTextBoxColumn Urlfoto;
    }
}
