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
    public partial class frmRepActPorUsuario : Form
    {
        public frmRepActPorUsuario()
        {
            InitializeComponent();
        }

        private void frmRepActPorUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsActPorUsuario.SP_ReporteActPorUsuarios' Puede moverla o quitarla según sea necesario.
            this.sP_ReporteActPorUsuariosTableAdapter.Fill(this.dsActPorUsuario.SP_ReporteActPorUsuarios);
            // TODO: esta línea de código carga datos en la tabla 'dsActPorUsuario.SP_ReporteActPorUsuarios' Puede moverla o quitarla según sea necesario.
            this.sP_ReporteActPorUsuariosTableAdapter.Fill(this.dsActPorUsuario.SP_ReporteActPorUsuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
