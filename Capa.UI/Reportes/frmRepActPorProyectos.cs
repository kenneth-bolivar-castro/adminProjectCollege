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
    public partial class frmRepActPorProyectos : Form
    {
        public frmRepActPorProyectos()
        {
            InitializeComponent();
        }

        private void frmRepActPorProyectos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adminProyectosDataSet.SP_ReporteActPorProyectos' Puede moverla o quitarla según sea necesario.
            this.sP_ReporteActPorProyectosTableAdapter.Fill(this.adminProyectosDataSet.SP_ReporteActPorProyectos);
            this.reportViewer1.RefreshReport();
        }
    }
}
