namespace Capa.UI.Reportes
{
    partial class frmReportUsuarioAsignado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsActPorUsuarioAsignado = new Capa.UI.dsActPorUsuarioAsignado();
            this.sPReporteActividadAsignadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ReporteActividadAsignadasTableAdapter = new Capa.UI.dsActPorUsuarioAsignadoTableAdapters.SP_ReporteActividadAsignadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsActPorUsuarioAsignado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteActividadAsignadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsActPorUsuarAsig";
            reportDataSource1.Value = this.sPReporteActividadAsignadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repActPorUsuarioAsignado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1008, 658);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsActPorUsuarioAsignado
            // 
            this.dsActPorUsuarioAsignado.DataSetName = "dsActPorUsuarioAsignado";
            this.dsActPorUsuarioAsignado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPReporteActividadAsignadasBindingSource
            // 
            this.sPReporteActividadAsignadasBindingSource.DataMember = "SP_ReporteActividadAsignadas";
            this.sPReporteActividadAsignadasBindingSource.DataSource = this.dsActPorUsuarioAsignado;
            // 
            // sP_ReporteActividadAsignadasTableAdapter
            // 
            this.sP_ReporteActividadAsignadasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportUsuarioAsignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 658);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportUsuarioAsignado";
            this.Text = "frmReportUsuarioAsignado";
            this.Load += new System.EventHandler(this.frmReportUsuarioAsignado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsActPorUsuarioAsignado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteActividadAsignadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPReporteActividadAsignadasBindingSource;
        private dsActPorUsuarioAsignado dsActPorUsuarioAsignado;
        private dsActPorUsuarioAsignadoTableAdapters.SP_ReporteActividadAsignadasTableAdapter sP_ReporteActividadAsignadasTableAdapter;
    }
}