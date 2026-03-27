namespace presentation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.camionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerCamionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camionesToolStripMenuItem,
            this.rutasToolStripMenuItem,
            this.choferToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // camionesToolStripMenuItem
            // 
            this.camionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.obtenerCamionToolStripMenuItem});
            this.camionesToolStripMenuItem.Name = "camionesToolStripMenuItem";
            this.camionesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.camionesToolStripMenuItem.Text = "Camiones";
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.mostrarTodosToolStripMenuItem.Text = "Mostrar todos";
            this.mostrarTodosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // obtenerCamionToolStripMenuItem
            // 
            this.obtenerCamionToolStripMenuItem.Name = "obtenerCamionToolStripMenuItem";
            this.obtenerCamionToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.obtenerCamionToolStripMenuItem.Text = "Obtener camion";
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.agregarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.obtenerToolStripMenuItem});
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.rutasToolStripMenuItem.Text = "Rutas";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.mostrarToolStripMenuItem.Text = "Mostrar todos";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(185, 26);
            this.agregarToolStripMenuItem1.Text = "agregar ";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(185, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // obtenerToolStripMenuItem
            // 
            this.obtenerToolStripMenuItem.Name = "obtenerToolStripMenuItem";
            this.obtenerToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.obtenerToolStripMenuItem.Text = "Obtener";
            // 
            // choferToolStripMenuItem
            // 
            this.choferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosToolStripMenuItem1,
            this.agregarToolStripMenuItem2,
            this.eliminarToolStripMenuItem2,
            this.obtenerToolStripMenuItem1});
            this.choferToolStripMenuItem.Name = "choferToolStripMenuItem";
            this.choferToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.choferToolStripMenuItem.Text = "Chofer";
            // 
            // mostrarTodosToolStripMenuItem1
            // 
            this.mostrarTodosToolStripMenuItem1.Name = "mostrarTodosToolStripMenuItem1";
            this.mostrarTodosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.mostrarTodosToolStripMenuItem1.Text = "Mostrar todos";
            this.mostrarTodosToolStripMenuItem1.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem1_Click);
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            // 
            // obtenerToolStripMenuItem1
            // 
            this.obtenerToolStripMenuItem1.Name = "obtenerToolStripMenuItem1";
            this.obtenerToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.obtenerToolStripMenuItem1.Text = "Obtener";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 291);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista camiones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Tipo,
            this.Modelo,
            this.Marca,
            this.Disponibilidad,
            this.Kilometraje,
            this.UrlFoto});
            this.dataGridView1.Location = new System.Drawing.Point(21, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 125;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.HeaderText = "Disponibilidad";
            this.Disponibilidad.MinimumWidth = 6;
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.ReadOnly = true;
            this.Disponibilidad.Width = 125;
            // 
            // Kilometraje
            // 
            this.Kilometraje.HeaderText = "Kilometraje";
            this.Kilometraje.MinimumWidth = 6;
            this.Kilometraje.Name = "Kilometraje";
            this.Kilometraje.ReadOnly = true;
            this.Kilometraje.Width = 125;
            // 
            // UrlFoto
            // 
            this.UrlFoto.HeaderText = "Url foto";
            this.UrlFoto.MinimumWidth = 6;
            this.UrlFoto.Name = "UrlFoto";
            this.UrlFoto.ReadOnly = true;
            this.UrlFoto.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 367);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administrador de transportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem camionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerCamionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obtenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem obtenerToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

