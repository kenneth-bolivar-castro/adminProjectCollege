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
    public partial class frmRepHistorial : Form
    {
        public frmRepHistorial()
        {
            InitializeComponent();
        }

        private void frmRepHistorial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsReporteHistorial.SP_ReporteHistorial' Puede moverla o quitarla según sea necesario.
            this.sP_ReporteHistorialTableAdapter.Fill(this.dsReporteHistorial.SP_ReporteHistorial);

            this.reportViewer1.RefreshReport();
        }
    }
}
