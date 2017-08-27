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
    public partial class frmRepUsuarioPorProyecto : Form
    {
        public frmRepUsuarioPorProyecto()
        {
            InitializeComponent();
        }

        private void frmRepUsuarioPorProyecto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsUsuariosPorProyectos.SP_RepUsuariosPorProyecto' Puede moverla o quitarla según sea necesario.
            this.sP_RepUsuariosPorProyectoTableAdapter.Fill(this.dsUsuariosPorProyectos.SP_RepUsuariosPorProyecto);



            this.reportViewer1.RefreshReport();
        }
    }
}
