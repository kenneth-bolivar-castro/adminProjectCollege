namespace Capa.UI.Reportes
{
    partial class frmRepActPorUsuario
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
            this.dsActPorUsuario = new Capa.UI.dsActPorUsuario();
            this.sPReporteActPorUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ReporteActPorUsuariosTableAdapter = new Capa.UI.dsActPorUsuarioTableAdapters.SP_ReporteActPorUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsActPorUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteActPorUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsRepActividadPorUsuario";
            reportDataSource2.Value = this.sPReporteActPorUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repActPorUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1084, 915);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsActPorUsuario
            // 
            this.dsActPorUsuario.DataSetName = "dsActPorUsuario";
            this.dsActPorUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPReporteActPorUsuariosBindingSource
            // 
            this.sPReporteActPorUsuariosBindingSource.DataMember = "SP_ReporteActPorUsuarios";
            this.sPReporteActPorUsuariosBindingSource.DataSource = this.dsActPorUsuario;
            // 
            // sP_ReporteActPorUsuariosTableAdapter
            // 
            this.sP_ReporteActPorUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepActPorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 915);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepActPorUsuario";
            this.Text = "Actividad por Usuarios";
            this.Load += new System.EventHandler(this.frmRepActPorUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsActPorUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteActPorUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsActPorUsuario dsActPorUsuario;
        private System.Windows.Forms.BindingSource sPReporteActPorUsuariosBindingSource;
        private dsActPorUsuarioTableAdapters.SP_ReporteActPorUsuariosTableAdapter sP_ReporteActPorUsuariosTableAdapter;
    }
}