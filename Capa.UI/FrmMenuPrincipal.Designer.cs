namespace Capa.UI
{
    partial class FrmMenuPrincipal
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
            this.txtBienv = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTipoActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstProyectos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrirProyecto = new System.Windows.Forms.Button();
            this.btnDetallProy = new System.Windows.Forms.Button();
            this.btnEliminarProy = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevAct = new System.Windows.Forms.Button();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.porGravedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBienv
            // 
            this.txtBienv.Location = new System.Drawing.Point(29, 64);
            this.txtBienv.Name = "txtBienv";
            this.txtBienv.ReadOnly = true;
            this.txtBienv.Size = new System.Drawing.Size(251, 31);
            this.txtBienv.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1301, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaActividadToolStripMenuItem,
            this.nuevoProyectoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(107, 38);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaActividadToolStripMenuItem
            // 
            this.nuevaActividadToolStripMenuItem.Name = "nuevaActividadToolStripMenuItem";
            this.nuevaActividadToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.nuevaActividadToolStripMenuItem.Text = "Nueva Actividad";
            this.nuevaActividadToolStripMenuItem.Click += new System.EventHandler(this.nuevaActividadToolStripMenuItem_Click);
            // 
            // nuevoProyectoToolStripMenuItem
            // 
            this.nuevoProyectoToolStripMenuItem.Name = "nuevoProyectoToolStripMenuItem";
            this.nuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.nuevoProyectoToolStripMenuItem.Text = "Nuevo Proyecto";
            this.nuevoProyectoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProyectoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadesToolStripMenuItem,
            this.usuariosToolStripMenuItem1,
            this.graficoActividadesToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(120, 38);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porProyectosToolStripMenuItem,
            this.porUsuariosToolStripMenuItem,
            this.porTipoActividadToolStripMenuItem,
            this.porGravedadToolStripMenuItem,
            this.delUsuarioToolStripMenuItem});
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // porProyectosToolStripMenuItem
            // 
            this.porProyectosToolStripMenuItem.Name = "porProyectosToolStripMenuItem";
            this.porProyectosToolStripMenuItem.Size = new System.Drawing.Size(307, 38);
            this.porProyectosToolStripMenuItem.Text = "Por Proyectos";
            this.porProyectosToolStripMenuItem.Click += new System.EventHandler(this.porProyectosToolStripMenuItem_Click);
            // 
            // porUsuariosToolStripMenuItem
            // 
            this.porUsuariosToolStripMenuItem.Name = "porUsuariosToolStripMenuItem";
            this.porUsuariosToolStripMenuItem.Size = new System.Drawing.Size(307, 38);
            this.porUsuariosToolStripMenuItem.Text = "Por Usuarios";
            this.porUsuariosToolStripMenuItem.Click += new System.EventHandler(this.porUsuariosToolStripMenuItem_Click);
            // 
            // porTipoActividadToolStripMenuItem
            // 
            this.porTipoActividadToolStripMenuItem.Name = "porTipoActividadToolStripMenuItem";
            this.porTipoActividadToolStripMenuItem.Size = new System.Drawing.Size(307, 38);
            this.porTipoActividadToolStripMenuItem.Text = "Por Tipo Actividad";
            this.porTipoActividadToolStripMenuItem.Click += new System.EventHandler(this.porTipoActividadToolStripMenuItem_Click);
            // 
            // delUsuarioToolStripMenuItem
            // 
            this.delUsuarioToolStripMenuItem.Name = "delUsuarioToolStripMenuItem";
            this.delUsuarioToolStripMenuItem.Size = new System.Drawing.Size(307, 38);
            this.delUsuarioToolStripMenuItem.Text = "Del Usuario";
            this.delUsuarioToolStripMenuItem.Click += new System.EventHandler(this.delUsuarioToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porProyectoToolStripMenuItem});
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(317, 38);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // porProyectoToolStripMenuItem
            // 
            this.porProyectoToolStripMenuItem.Name = "porProyectoToolStripMenuItem";
            this.porProyectoToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.porProyectoToolStripMenuItem.Text = "Por Proyecto";
            this.porProyectoToolStripMenuItem.Click += new System.EventHandler(this.porProyectoToolStripMenuItem_Click);
            // 
            // graficoActividadesToolStripMenuItem
            // 
            this.graficoActividadesToolStripMenuItem.Name = "graficoActividadesToolStripMenuItem";
            this.graficoActividadesToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.graficoActividadesToolStripMenuItem.Text = "Grafico Actividades";
            this.graficoActividadesToolStripMenuItem.Click += new System.EventHandler(this.graficoActividadesToolStripMenuItem_Click);
            // 
            // lstProyectos
            // 
            this.lstProyectos.FormattingEnabled = true;
            this.lstProyectos.ItemHeight = 25;
            this.lstProyectos.Location = new System.Drawing.Point(22, 30);
            this.lstProyectos.Name = "lstProyectos";
            this.lstProyectos.Size = new System.Drawing.Size(696, 254);
            this.lstProyectos.TabIndex = 2;
            this.lstProyectos.SelectedIndexChanged += new System.EventHandler(this.lstProyectos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstProyectos);
            this.groupBox1.Controls.Add(this.btnAbrirProyecto);
            this.groupBox1.Controls.Add(this.btnDetallProy);
            this.groupBox1.Controls.Add(this.btnEliminarProy);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(29, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 303);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proyectos";
            // 
            // btnAbrirProyecto
            // 
            this.btnAbrirProyecto.Location = new System.Drawing.Point(1030, 54);
            this.btnAbrirProyecto.Name = "btnAbrirProyecto";
            this.btnAbrirProyecto.Size = new System.Drawing.Size(175, 68);
            this.btnAbrirProyecto.TabIndex = 6;
            this.btnAbrirProyecto.Text = "Abrir Proyecto";
            this.btnAbrirProyecto.UseVisualStyleBackColor = true;
            this.btnAbrirProyecto.Click += new System.EventHandler(this.btnAbrirProyecto_Click);
            // 
            // btnDetallProy
            // 
            this.btnDetallProy.Location = new System.Drawing.Point(1030, 159);
            this.btnDetallProy.Name = "btnDetallProy";
            this.btnDetallProy.Size = new System.Drawing.Size(175, 68);
            this.btnDetallProy.TabIndex = 4;
            this.btnDetallProy.Text = "Detalles Proyecto";
            this.btnDetallProy.UseVisualStyleBackColor = true;
            this.btnDetallProy.Click += new System.EventHandler(this.btnDetallProy_Click);
            // 
            // btnEliminarProy
            // 
            this.btnEliminarProy.Location = new System.Drawing.Point(775, 159);
            this.btnEliminarProy.Name = "btnEliminarProy";
            this.btnEliminarProy.Size = new System.Drawing.Size(175, 68);
            this.btnEliminarProy.TabIndex = 7;
            this.btnEliminarProy.Text = "Eliminar Proyecto";
            this.btnEliminarProy.UseVisualStyleBackColor = true;
            this.btnEliminarProy.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(775, 54);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 68);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo Proyecto";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(775, 98);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(175, 68);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir Actividad";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNuevAct);
            this.groupBox2.Controls.Add(this.dgvActividades);
            this.groupBox2.Controls.Add(this.btnAbrir);
            this.groupBox2.Location = new System.Drawing.Point(29, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1245, 400);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actividades";
            // 
            // btnNuevAct
            // 
            this.btnNuevAct.Location = new System.Drawing.Point(775, 218);
            this.btnNuevAct.Name = "btnNuevAct";
            this.btnNuevAct.Size = new System.Drawing.Size(175, 68);
            this.btnNuevAct.TabIndex = 6;
            this.btnNuevAct.Text = "Nueva Actividad";
            this.btnNuevAct.UseVisualStyleBackColor = true;
            this.btnNuevAct.Click += new System.EventHandler(this.btnNuevAct_Click);
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(22, 62);
            this.dgvActividades.MultiSelect = false;
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowTemplate.Height = 33;
            this.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActividades.Size = new System.Drawing.Size(696, 313);
            this.dgvActividades.TabIndex = 0;
            this.dgvActividades.SelectionChanged += new System.EventHandler(this.dgvActividades_SelectionChanged);
            // 
            // porGravedadToolStripMenuItem
            // 
            this.porGravedadToolStripMenuItem.Name = "porGravedadToolStripMenuItem";
            this.porGravedadToolStripMenuItem.Size = new System.Drawing.Size(307, 38);
            this.porGravedadToolStripMenuItem.Text = "Por Gravedad";
            this.porGravedadToolStripMenuItem.Click += new System.EventHandler(this.porGravedadToolStripMenuItem_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa.UI.Properties.Resources.background_m3_login_for_m1_by_andreascy_d3ecbzg;
            this.ClientSize = new System.Drawing.Size(1301, 902);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBienv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBienv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ListBox lstProyectos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetallProy;
        private System.Windows.Forms.ToolStripMenuItem nuevoProyectoToolStripMenuItem;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnAbrirProyecto;
        private System.Windows.Forms.Button btnEliminarProy;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.ToolStripMenuItem nuevaActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTipoActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoActividadesToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevAct;
        private System.Windows.Forms.ToolStripMenuItem delUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porGravedadToolStripMenuItem;
    }
}