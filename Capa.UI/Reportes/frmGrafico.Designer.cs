namespace Capa.UI.Reportes
{
    partial class frmGrafico
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
            this.cboProyectos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsHorasActividades = new Capa.UI.dsHorasActividades();
            this.sPObtenerHorasActGraficosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ObtenerHorasActGraficosTableAdapter = new Capa.UI.dsHorasActividadesTableAdapters.SP_ObtenerHorasActGraficosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerHorasActGraficosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboProyectos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 100);
            this.panel1.TabIndex = 1;
            // 
            // cboProyectos
            // 
            this.cboProyectos.FormattingEnabled = true;
            this.cboProyectos.Location = new System.Drawing.Point(220, 33);
            this.cboProyectos.Name = "cboProyectos";
            this.cboProyectos.Size = new System.Drawing.Size(191, 33);
            this.cboProyectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyectos";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(746, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsHorasActividades";
            reportDataSource2.Value = this.sPObtenerHorasActGraficosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.repHorasActividadesGraficos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(892, 540);
            this.reportViewer1.TabIndex = 2;
            // 
            // dsHorasActividades
            // 
            this.dsHorasActividades.DataSetName = "dsHorasActividades";
            this.dsHorasActividades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPObtenerHorasActGraficosBindingSource
            // 
            this.sPObtenerHorasActGraficosBindingSource.DataMember = "SP_ObtenerHorasActGraficos";
            this.sPObtenerHorasActGraficosBindingSource.DataSource = this.dsHorasActividades;
            // 
            // sP_ObtenerHorasActGraficosTableAdapter
            // 
            this.sP_ObtenerHorasActGraficosTableAdapter.ClearBeforeFill = true;
            // 
            // frmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 640);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGrafico";
            this.Text = "Grafico Horas Actividades por Proyecto";
            this.Load += new System.EventHandler(this.frmGrafico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerHorasActGraficosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProyectos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPObtenerHorasActGraficosBindingSource;
        private dsHorasActividades dsHorasActividades;
        private dsHorasActividadesTableAdapters.SP_ObtenerHorasActGraficosTableAdapter sP_ObtenerHorasActGraficosTableAdapter;
    }
}