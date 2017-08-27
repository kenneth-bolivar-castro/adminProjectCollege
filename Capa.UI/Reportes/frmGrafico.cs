using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Reportes
{
    public partial class frmGrafico : Form
    {
        public frmGrafico()
        {
            InitializeComponent();
        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            this.LlenarCombo();
            Entidades.ProyectoEnt proy = this.cboProyectos.SelectedItem as Entidades.ProyectoEnt;

            sP_ObtenerHorasActGraficosTableAdapter.Fill
                (dsHorasActividades.SP_ObtenerHorasActGraficos, proy.Id);
            this.reportViewer1.RefreshReport();
        }

        private void LlenarCombo()
        {
            this.cboProyectos.DataSource = Logica.Class.Proyecto.ObtenerProyectos();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Entidades.ProyectoEnt proy = this.cboProyectos.SelectedItem as Entidades.ProyectoEnt;

            sP_ObtenerHorasActGraficosTableAdapter.Fill
                (dsHorasActividades.SP_ObtenerHorasActGraficos, proy.Id);
            this.reportViewer1.RefreshReport();
            //int catId = (int)cboCategoria.SelectedValue;
            //pA_SeleccionarEventosReportePorCateogiraTableAdapter.Fill(
            //bdEventoPorCategoria.PA_SeleccionarEventosReportePorCateogira, catId);
            //string titulo = "Reporte eventos para la categoria " + cboCategoria.Text;
            //ReportParameter repTitulo = new ReportParameter(
            //"paramTitulo", titulo);
            //this.reportViewer1.LocalReport.SetParameters(repTitulo);
            //this.reportViewer1.RefreshReport();

        }
    }
}
