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
    public partial class frmRepActPorGravedad : Form
    {
        public frmRepActPorGravedad()
        {
            InitializeComponent();
        }

        private void frmRepActPorGravedad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsActividadesPorGravedad.SP_RepPorGravedad' Puede moverla o quitarla según sea necesario.
            this.sP_RepPorGravedadTableAdapter.Fill(this.dsActividadesPorGravedad.SP_RepPorGravedad);

            this.reportViewer1.RefreshReport();
        }
    }
}
