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
    public partial class frmRepActividadPorTipoActividad : Form
    {
        public frmRepActividadPorTipoActividad()
        {
            InitializeComponent();
        }

        private void repActividadPorTipoActividad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsActividadPorTipoActividad.SP_RepActPorTipoAct' Puede moverla o quitarla según sea necesario.
            this.sP_RepActPorTipoActTableAdapter.Fill(this.dsActividadPorTipoActividad.SP_RepActPorTipoAct);

            this.reportViewer1.RefreshReport();
        }
    }
}
