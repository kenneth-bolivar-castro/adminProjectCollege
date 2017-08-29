namespace Capa.UI.Reportes
{
    partial class frmReporteActividadesProyectoAsignado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProyectos = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dsActProyectoAsig = new Capa.UI.dsActProyectoAsig();
            this.sPReporteActividadesProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ReporteActividadesProyectoTableAdapter = new Capa.UI.dsActProyectoAsigTableAdapters.SP_ReporteActividadesProyectoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsActProyectoAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteActividadesProyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefrescar);
            this.panel1.Controls.Add(this.cboProyectos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 100);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsRepActividProyAsig";
            reportDataSource2.Value = this.sPReporteActividadesProyectoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repActividadesProyectoAsig.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(802, 356);
            this.reportViewer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyectos";
            // 
            // cboProyectos
            // 
            this.cboProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProyectos.FormattingEnabled = true;
            this.cboProyectos.Location = new System.Drawing.Point(357, 32);
            this.cboProyectos.Name = "cboProyectos";
            this.cboProyectos.Size = new System.Drawing.Size(140, 33);
            this.cboProyectos.TabIndex = 1;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(599, 15);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(140, 64);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dsActProyectoAsig
            // 
            this.dsActProyectoAsig.DataSetName = "dsActProyectoAsig";
            this.dsActProyectoAsig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPReporteActividadesProyectoBindingSource
            // 
            this.sPReporteActividadesProyectoBindingSource.DataMember = "SP_ReporteActividadesProyecto";
            this.sPReporteActividadesProyectoBindingSource.DataSource = this.dsActProyectoAsig;
            // 
            // sP_ReporteActividadesProyectoTableAdapter
            // 
            this.sP_ReporteActividadesProyectoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteActividadesProyectoAsignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 456);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmReporteActividadesProyectoAsignado";
            this.Text = "Reporte de Actividades de Proyecto";
            this.Load += new System.EventHandler(this.frmReporteActividadesProyectoAsignado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsActProyectoAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteActividadesProyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox cboProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sPReporteActividadesProyectoBindingSource;
        private dsActProyectoAsig dsActProyectoAsig;
        private dsActProyectoAsigTableAdapters.SP_ReporteActividadesProyectoTableAdapter sP_ReporteActividadesProyectoTableAdapter;
    }
}