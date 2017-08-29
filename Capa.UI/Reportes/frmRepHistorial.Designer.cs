namespace Capa.UI.Reportes
{
    partial class frmRepHistorial
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
            this.dsReporteHistorial = new Capa.UI.dsReporteHistorial();
            this.sPReporteHistorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ReporteHistorialTableAdapter = new Capa.UI.dsReporteHistorialTableAdapters.SP_ReporteHistorialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteHistorialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsReporteHistorial";
            reportDataSource1.Value = this.sPReporteHistorialBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repHistorial.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(906, 548);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsReporteHistorial
            // 
            this.dsReporteHistorial.DataSetName = "dsReporteHistorial";
            this.dsReporteHistorial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPReporteHistorialBindingSource
            // 
            this.sPReporteHistorialBindingSource.DataMember = "SP_ReporteHistorial";
            this.sPReporteHistorialBindingSource.DataSource = this.dsReporteHistorial;
            // 
            // sP_ReporteHistorialTableAdapter
            // 
            this.sP_ReporteHistorialTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 548);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepHistorial";
            this.Text = "Historial de Cambios";
            this.Load += new System.EventHandler(this.frmRepHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteHistorialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsReporteHistorial dsReporteHistorial;
        private System.Windows.Forms.BindingSource sPReporteHistorialBindingSource;
        private dsReporteHistorialTableAdapters.SP_ReporteHistorialTableAdapter sP_ReporteHistorialTableAdapter;
    }
}