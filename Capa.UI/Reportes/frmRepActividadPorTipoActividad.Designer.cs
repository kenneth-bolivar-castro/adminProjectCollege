namespace Capa.UI.Reportes
{
    partial class frmRepActividadPorTipoActividad
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
            this.sPRepActPorTipoActBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsActividadPorTipoActividad = new Capa.UI.dsActividadPorTipoActividad();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_RepActPorTipoActTableAdapter = new Capa.UI.dsActividadPorTipoActividadTableAdapters.SP_RepActPorTipoActTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPRepActPorTipoActBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActividadPorTipoActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // sPRepActPorTipoActBindingSource
            // 
            this.sPRepActPorTipoActBindingSource.DataMember = "SP_RepActPorTipoAct";
            this.sPRepActPorTipoActBindingSource.DataSource = this.dsActividadPorTipoActividad;
            // 
            // dsActividadPorTipoActividad
            // 
            this.dsActividadPorTipoActividad.DataSetName = "dsActividadPorTipoActividad";
            this.dsActividadPorTipoActividad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsActPorTipoActividad";
            reportDataSource1.Value = this.sPRepActPorTipoActBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repActPorTipoActividad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(764, 650);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_RepActPorTipoActTableAdapter
            // 
            this.sP_RepActPorTipoActTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepActividadPorTipoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 650);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepActividadPorTipoActividad";
            this.Text = "Actividad Por Tipo Actividad";
            this.Load += new System.EventHandler(this.repActividadPorTipoActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPRepActPorTipoActBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActividadPorTipoActividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsActividadPorTipoActividad dsActividadPorTipoActividad;
        private System.Windows.Forms.BindingSource sPRepActPorTipoActBindingSource;
        private dsActividadPorTipoActividadTableAdapters.SP_RepActPorTipoActTableAdapter sP_RepActPorTipoActTableAdapter;
    }
}