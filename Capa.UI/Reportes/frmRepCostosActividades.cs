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
    public partial class frmRepCostosActividades : Form
    {
        public frmRepCostosActividades()
        {
            InitializeComponent();
        }

        private void frmRepCostosActividades_Load(object sender, EventArgs e)
        {
            this.cboProyectos.DataSource = Logica.Class.Proyecto.ObtenerProyectos();

            Entidades.ProyectoEnt proy = this.cboProyectos.SelectedItem as Entidades.ProyectoEnt;

            // TODO: esta línea de código carga datos en la tabla 'dsActividadesPorGravedad.SP_RepPorGravedad' Puede moverla o quitarla según sea necesario.
            this.sP_ReporteCostoActividadesPorProyTableAdapter.Fill(this.dsCostosActividadesProy.SP_ReporteCostoActividadesPorProy,proy.Id);

            this.reportViewer1.RefreshReport();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Entidades.ProyectoEnt proy = this.cboProyectos.SelectedItem as Entidades.ProyectoEnt;

            this.sP_ReporteCostoActividadesPorProyTableAdapter.Fill(this.dsCostosActividadesProy.SP_ReporteCostoActividadesPorProy, proy.Id);

            this.reportViewer1.RefreshReport();
        }
    }
}
