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
            this.sP_ReporteActividadAsignadasTableAdapter.Fill(this.dsActPorUsuarioAsignado.SP_ReporteActividadAsignadas, FrmLogIn.usuario.id);

            this.reportViewer1.RefreshReport();
        }
    }
}
