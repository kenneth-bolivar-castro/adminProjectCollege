namespace Capa.UI.Reportes
{
    partial class frmRepUsuarioPorProyecto
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsUsuariosPorProyectos = new Capa.UI.dsUsuariosPorProyectos();
            this.sPRepUsuariosPorProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_RepUsuariosPorProyectoTableAdapter = new Capa.UI.dsUsuariosPorProyectosTableAdapters.SP_RepUsuariosPorProyectoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosPorProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRepUsuariosPorProyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsRepUsuarPorProyecto";
            reportDataSource2.Value = this.sPRepUsuariosPorProyectoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repUsuariosProyectos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(880, 890);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsUsuariosPorProyectos
            // 
            this.dsUsuariosPorProyectos.DataSetName = "dsUsuariosPorProyectos";
            this.dsUsuariosPorProyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPRepUsuariosPorProyectoBindingSource
            // 
            this.sPRepUsuariosPorProyectoBindingSource.DataMember = "SP_RepUsuariosPorProyecto";
            this.sPRepUsuariosPorProyectoBindingSource.DataSource = this.dsUsuariosPorProyectos;
            // 
            // sP_RepUsuariosPorProyectoTableAdapter
            // 
            this.sP_RepUsuariosPorProyectoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepUsuarioPorProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 890);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepUsuarioPorProyecto";
            this.Text = "Usuarios por Proyecto";
            this.Load += new System.EventHandler(this.frmRepUsuarioPorProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosPorProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRepUsuariosPorProyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsUsuariosPorProyectos dsUsuariosPorProyectos;
        private System.Windows.Forms.BindingSource sPRepUsuariosPorProyectoBindingSource;
        private dsUsuariosPorProyectosTableAdapters.SP_RepUsuariosPorProyectoTableAdapter sP_RepUsuariosPorProyectoTableAdapter;
    }
}