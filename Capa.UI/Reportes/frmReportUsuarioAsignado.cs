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
    public partial class frmReportUsuarioAsignado : Form
    {
        public frmReportUsuarioAsignado()
        {
            InitializeComponent();
        }

        private void frmReportUsuarioAsignado_Load(object sender, EventArgs e)
        {
            this.cboProyectos.DataSource = Logica.Class.Proyecto.ObtenerProyectosPorUsuarios(FrmLogIn.usuario.id);

            Entidades.ProyectoEnt proy = this.cboProyectos.SelectedItem as Entidades.ProyectoEnt;

            if(proy == null)
            {
                
                MessageBox.Show("No hay ningun proyecto seleccionado");
                this.Close();
                return;
                
            }
            this.sP_ReporteActividadAsignadasTableAdapter.Fill(this.dsActividadesDelUsuario.SP_ReporteActividadAsignadas, FrmLogIn.usuario.id, proy.Id);
            this.reportViewer1.RefreshReport();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Entidades.ProyectoEnt proy = this.cboProyectos.SelectedItem as Entidades.ProyectoEnt;

            this.sP_ReporteActividadAsignadasTableAdapter.Fill(this.dsActividadesDelUsuario.SP_ReporteActividadAsignadas, FrmLogIn.usuario.id, proy.Id);
            this.reportViewer1.RefreshReport();
        }
    }
}
