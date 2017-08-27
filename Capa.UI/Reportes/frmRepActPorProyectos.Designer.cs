namespace Capa.UI.Reportes
{
    partial class frmRepActPorProyectos
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
            this.adminProyectosDataSet = new Capa.UI.AdminProyectosDataSet();
            this.sPReporteActPorProyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ReporteActPorProyectosTableAdapter = new Capa.UI.AdminProyectosDataSetTableAdapters.SP_ReporteActPorProyectosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adminProyectosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteActPorProyectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsActividadPorProyecto";
            reportDataSource2.Value = this.sPReporteActPorProyectosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repActividadPorProyecto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 525);
            this.reportViewer1.TabIndex = 0;
            // 
            // adminProyectosDataSet
            // 
            this.adminProyectosDataSet.DataSetName = "AdminProyectosDataSet";
            this.adminProyectosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPReporteActPorProyectosBindingSource
            // 
            this.sPReporteActPorProyectosBindingSource.DataMember = "SP_ReporteActPorProyectos";
            this.sPReporteActPorProyectosBindingSource.DataSource = this.adminProyectosDataSet;
            // 
            // sP_ReporteActPorProyectosTableAdapter
            // 
            this.sP_ReporteActPorProyectosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepActPorProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 525);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepActPorProyectos";
            this.Text = "Actividad Por Proyectos";
            this.Load += new System.EventHandler(this.frmRepActPorProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminProyectosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteActPorProyectosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AdminProyectosDataSet adminProyectosDataSet;
        private System.Windows.Forms.BindingSource sPReporteActPorProyectosBindingSource;
        private AdminProyectosDataSetTableAdapters.SP_ReporteActPorProyectosTableAdapter sP_ReporteActPorProyectosTableAdapter;
    }
}