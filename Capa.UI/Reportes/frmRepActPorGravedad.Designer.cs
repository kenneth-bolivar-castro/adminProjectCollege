namespace Capa.UI.Reportes
{
    partial class frmRepActPorGravedad
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
            this.dsActividadesPorGravedad = new Capa.UI.dsActividadesPorGravedad();
            this.sPRepPorGravedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_RepPorGravedadTableAdapter = new Capa.UI.dsActividadesPorGravedadTableAdapters.SP_RepPorGravedadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsActividadesPorGravedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRepPorGravedadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsActPorGravedad";
            reportDataSource1.Value = this.sPRepPorGravedadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repActPorGravedad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(844, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsActividadesPorGravedad
            // 
            this.dsActividadesPorGravedad.DataSetName = "dsActividadesPorGravedad";
            this.dsActividadesPorGravedad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPRepPorGravedadBindingSource
            // 
            this.sPRepPorGravedadBindingSource.DataMember = "SP_RepPorGravedad";
            this.sPRepPorGravedadBindingSource.DataSource = this.dsActividadesPorGravedad;
            // 
            // sP_RepPorGravedadTableAdapter
            // 
            this.sP_RepPorGravedadTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepActPorGravedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 510);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepActPorGravedad";
            this.Text = "frmRepActPorGravedad";
            this.Load += new System.EventHandler(this.frmRepActPorGravedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsActividadesPorGravedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRepPorGravedadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsActividadesPorGravedad dsActividadesPorGravedad;
        private System.Windows.Forms.BindingSource sPRepPorGravedadBindingSource;
        private dsActividadesPorGravedadTableAdapters.SP_RepPorGravedadTableAdapter sP_RepPorGravedadTableAdapter;
    }
}