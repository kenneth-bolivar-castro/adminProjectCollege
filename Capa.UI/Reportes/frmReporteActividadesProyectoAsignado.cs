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
    public partial class frmReporteActividadesProyectoAsignado : Form
    {
        public frmReporteActividadesProyectoAsignado()
        {
            InitializeComponent();
        }

        private void frmReporteActividadesProyectoAsignado_Load(object sender, EventArgs e)
        {
            this.cboProyectos.DataSource = Logica.Class.Proyecto.ObtenerProyectosPorUsuarios(FrmLogIn.usuario.id);

            Entidades.ProyectoEnt proy = this.cboProyectos.SelectedItem as Entidades.ProyectoEnt;

            this.sP_ReporteActividadesProyectoTableAdapter.Fill(this.dsActProyectoAsig.SP_ReporteActividadesProyecto, proy.Id);
            this.reportViewer1.RefreshReport();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Entidades.ProyectoEnt proy = this.cboProyectos.SelectedItem as Entidades.ProyectoEnt;

            this.sP_ReporteActividadesProyectoTableAdapter.Fill(this.dsActProyectoAsig.SP_ReporteActividadesProyecto, proy.Id);
            this.reportViewer1.RefreshReport();
        }
    }
}
