namespace Capa.UI.Reportes
{
    partial class frmRepCostosActividades
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsCostosActividadesProy = new Capa.UI.dsCostosActividadesProy();
            this.sPReporteCostoActividadesPorProyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ReporteCostoActividadesPorProyTableAdapter = new Capa.UI.dsCostosActividadesProyTableAdapters.SP_ReporteCostoActividadesPorProyTableAdapter();
            this.cboProyectos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostosActividadesProy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteCostoActividadesPorProyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefrescar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboProyectos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 100);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCostoActividades";
            reportDataSource1.Value = this.sPReporteCostoActividadesPorProyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repCostoActividades.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(920, 429);
            this.reportViewer1.TabIndex = 1;
            // 
            // dsCostosActividadesProy
            // 
            this.dsCostosActividadesProy.DataSetName = "dsCostosActividadesProy";
            this.dsCostosActividadesProy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPReporteCostoActividadesPorProyBindingSource
            // 
            this.sPReporteCostoActividadesPorProyBindingSource.DataMember = "SP_ReporteCostoActividadesPorProy";
            this.sPReporteCostoActividadesPorProyBindingSource.DataSource = this.dsCostosActividadesProy;
            // 
            // sP_ReporteCostoActividadesPorProyTableAdapter
            // 
            this.sP_ReporteCostoActividadesPorProyTableAdapter.ClearBeforeFill = true;
            // 
            // cboProyectos
            // 
            this.cboProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProyectos.FormattingEnabled = true;
            this.cboProyectos.Location = new System.Drawing.Point(381, 41);
            this.cboProyectos.Name = "cboProyectos";
            this.cboProyectos.Size = new System.Drawing.Size(182, 33);
            this.cboProyectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyectos";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(694, 35);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(124, 43);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmRepCostosActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 529);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmRepCostosActividades";
            this.Text = "Reporte de Costos De Actividades";
            this.Load += new System.EventHandler(this.frmRepCostosActividades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostosActividadesProy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteCostoActividadesPorProyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProyectos;
        private System.Windows.Forms.BindingSource sPReporteCostoActividadesPorProyBindingSource;
        private dsCostosActividadesProy dsCostosActividadesProy;
        private dsCostosActividadesProyTableAdapters.SP_ReporteCostoActividadesPorProyTableAdapter sP_ReporteCostoActividadesPorProyTableAdapter;
        private System.Windows.Forms.Button btnRefrescar;
    }
}