using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI
{
    public partial class FrmMenuPrincipal : Form
    {
        /// <summary>
        /// Variables static que son arrastradas por cada frame
        /// </summary>
        List<Entidades.ProyectoEnt> listProyect;
        public static Entidades.ProyectoEnt proyecto;
        public static bool flag = false;
        public static Entidades.ActividadEnt actividad;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Brinda los permisos dependiendo del usuario
        /// </summary>
        private void Permisos()
        {
            if (FrmLogIn.usuario.rol.idRol == 1)
            {
                this.mantenimientosToolStripMenuItem.Visible = true;
                this.nuevoProyectoToolStripMenuItem.Visible = true;
                this.txtBienv.Text = FrmLogIn.usuario.Nombre;
                this.llenarListaProyectos();
                this.btnEliminarProy.Enabled = true;
                this.btnDetallProy.Enabled = true;
                this.btnAbrirProyecto.Enabled = true;
                this.reporteToolStripMenuItem.Visible = true;
                this.reporteToolStripMenuItem.Visible = true;
                this.actividadesToolStripMenuItem.Enabled = true;
                this.porProyectosToolStripMenuItem.Enabled = true;
                this.porTipoActividadToolStripMenuItem.Enabled = true;
                this.porUsuariosToolStripMenuItem.Enabled = true;
                this.usuariosToolStripMenuItem1.Enabled = true;
                this.graficoActividadesToolStripMenuItem.Enabled = true;
                this.porGravedadToolStripMenuItem.Enabled = true;
                this.costosDeActividadesToolStripMenuItem.Enabled = true;
                this.historialToolStripMenuItem.Enabled = true;
                this.btnEliminarAct.Enabled = true;
                this.btnNuevAct.Enabled = true;
                this.btnAbrir.Enabled = true;
                this.deLosProyectosToolStripMenuItem.Visible = false;

            }
            else
            {
                if (FrmLogIn.usuario.rol.idRol == 2)
                {
                    this.btnNuevo.Enabled = true;
                    this.mantenimientosToolStripMenuItem.Visible = false;
                    this.txtBienv.Text = FrmLogIn.usuario.Nombre;
                    this.lstProyectos.DataSource = this.ProyectosPorUsuario(FrmLogIn.usuario.id);
                    this.btnEliminarProy.Enabled = false;
                    this.btnDetallProy.Enabled = true;
                    this.btnAbrirProyecto.Enabled = true;
                    this.nuevoProyectoToolStripMenuItem.Enabled = true;
                    this.reporteToolStripMenuItem.Visible = true;
                    this.actividadesToolStripMenuItem.Enabled = true;
                    this.porProyectosToolStripMenuItem.Enabled = false;
                    this.porTipoActividadToolStripMenuItem.Enabled = false;
                    this.porUsuariosToolStripMenuItem.Enabled = false;
                    this.usuariosToolStripMenuItem1.Enabled = false;
                    this.graficoActividadesToolStripMenuItem.Enabled = false;
                    this.porGravedadToolStripMenuItem.Enabled = false;
                    this.costosDeActividadesToolStripMenuItem.Enabled = false;
                    this.historialToolStripMenuItem.Enabled = false;
                    this.btnEliminarAct.Enabled = true;
                    this.btnNuevAct.Enabled = true;
                    this.btnAbrir.Enabled = true;
                    this.delUsuarioToolStripMenuItem.Visible = true;

                }
                else
                {
                    this.lstProyectos.DataSource = this.ProyectosPorUsuario(FrmLogIn.usuario.id);
                    this.nuevaActividadToolStripMenuItem.Enabled = false;
                    this.btnNuevo.Enabled = false;
                    this.nuevoProyectoToolStripMenuItem.Enabled = false;
                    this.mantenimientosToolStripMenuItem.Visible = false;
                    this.btnEliminarProy.Enabled = false;
                    this.btnDetallProy.Enabled = false;
                    this.btnAbrirProyecto.Enabled = false;
                    this.txtBienv.Text = FrmLogIn.usuario.Nombre;
                    this.reporteToolStripMenuItem.Visible = true;
                    this.actividadesToolStripMenuItem.Enabled = true;
                    this.porProyectosToolStripMenuItem.Enabled = false;
                    this.porTipoActividadToolStripMenuItem.Enabled = false;
                    this.porUsuariosToolStripMenuItem.Enabled = false;
                    this.usuariosToolStripMenuItem1.Enabled = false;
                    this.graficoActividadesToolStripMenuItem.Enabled = false;
                    this.porGravedadToolStripMenuItem.Enabled = false;
                    this.costosDeActividadesToolStripMenuItem.Enabled = false;
                    this.historialToolStripMenuItem.Enabled = false;
                    this.btnEliminarAct.Enabled = false;
                    this.btnNuevAct.Enabled = false;
                    this.btnAbrir.Enabled = true;
                    this.delUsuarioToolStripMenuItem.Visible = false;
                }
            }
        }
        /// <summary>
        /// Cambia el color de varias propiedades, da permisos y llena tablas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            proyecto = null;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.Permisos();
            this.llenarTablaActividad();
        }

        /// <summary>
        /// Llena la lista de proyectos en el momento de ingresar o cuando cierra algun frame hijo
        /// </summary>
        private void llenarListaProyectos()
        {
            this.listProyect = Logica.Class.Proyecto.ObtenerProyectos();

            this.lstProyectos.DataSource = this.listProyect;



        }


        /// <summary>
        /// Regresa el frame padre el logIn via instance de singleton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Abre el mantenimiento de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmMantenimientoUsuar frmMant = new FrmMantenimientoUsuar();
            frmMant.ShowDialog();

            //frmMant.ShowDialog();
        }

        /// <summary>
        /// Regresa los proyectos asociados con un usuario
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        private List<Entidades.ProyectoEnt> ProyectosPorUsuario(int idUser)
        {
            List<Entidades.ProyectoEnt> listaProyectos = Logica.Class.Proyecto.ObtenerProyectosPorUsuarios(idUser);


            return listaProyectos;


        }


        /// <summary>
        /// Muestra el detalle del proyecto Costos Nombre y Usuarios asignados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetallProy_Click(object sender, EventArgs e)
        {
            if (this.lstProyectos.SelectedItem == null)
            {
                MessageBox.Show("No hay proyectos asignados");
                return;
            }
            Entidades.ProyectoEnt proyecto = (Entidades.ProyectoEnt)this.lstProyectos.SelectedItem;
            proyecto.ListUsuarios = Logica.Class.Proyecto.ObtenerUsuariosPorProyectos(proyecto.Id);


            StringBuilder detalles = new StringBuilder();

            detalles.Append("Nombre Proyecto: ");
            detalles.Append(proyecto.Nombre);
            detalles.Append("\nTotal de Horas: ");
            detalles.Append(proyecto.TiempoTotalTrab);
            detalles.Append("\nCosto por Hora: ");
            detalles.Append(proyecto.CostoHora);
            detalles.Append("\nHoras Estimadas: ");
            detalles.Append(proyecto.TiempoEstimTrab);
            detalles.Append("\nTotal de Costo: ");
            detalles.Append(proyecto.TotCosto);
            detalles.Append("\nCosto Estimado: ");
            detalles.Append(proyecto.EstimCosto);
            detalles.Append("\nUsuarios Encargados: \n");


            foreach (Entidades.UsuarioEnt us in proyecto.ListUsuarios)
            {
                detalles.Append("ID: ");
                detalles.Append(us.id);
                detalles.Append("\nNombre: ");
                detalles.Append(us.Nombre);
                detalles.Append("\n");
            }

            MessageBox.Show(detalles.ToString());



        }


        /// <summary>
        /// Abre la actividad seleccionada 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (FrmLogIn.usuario.rol.idRol == 1)
            {
                if (actividad != null)
                {
                    flag = true;
                    FrmActividad frmAct = new FrmActividad();
                    frmAct.ShowDialog();
                    this.llenarTablaActividad();
                }
                else
                {
                    MessageBox.Show("No hay actividades disponibles");
                }
                this.llenarListaProyectos();
            }
            else
            {

                if (actividad == null)
                {
                    MessageBox.Show("No hay actividades disponibles");
                }
                else
                {
                    if (FrmLogIn.usuario.id == actividad.Usuario.id || FrmLogIn.usuario.rol.idRol == 2)
                    {
                        flag = true;
                        FrmActividad frmAct = new FrmActividad();
                        frmAct.ShowDialog();
                        this.llenarTablaActividad();
                    }
                    else
                    {
                        MessageBox.Show("La actividad no le pertenece");
                    }

                }
            }
        }


        /// <summary>
        /// Cambia las actividades q pertenecen segun el proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actividad = null;
            proyecto = (Entidades.ProyectoEnt)this.lstProyectos.SelectedItem;
            this.llenarTablaActividad();
        }



        /// <summary>
        /// Llena la tabla actividad segun el proyecto seleccionado
        /// </summary>
        private void llenarTablaActividad()
        {
            try
            {
                this.dgvActividades.DataSource = Logica.Class.Actividad.ObtenerListaPorProyecto(proyecto.Id);
                this.dgvActividades.Columns.RemoveAt(0);
                this.dgvActividades.Columns.RemoveAt(8);
                this.dgvActividades.Columns.RemoveAt(2);
            }
            catch (Exception ex)
            {

            }

        }

        /// <summary>
        /// Abre la ventana para crear un nuevo Proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            flag = false;
            FrmCreadorProy creadorProy = new FrmCreadorProy();
            creadorProy.ShowDialog();
            if (FrmLogIn.usuario.rol.idRol == 2 || FrmLogIn.usuario.rol.idRol == 3)
            {
                this.ProyectosPorUsuario(FrmLogIn.usuario.id);
            }
            else
            {
                this.llenarListaProyectos();
            }




        }

        /// <summary>
        ///  Abre la ventana para crear un proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = false;
            FrmCreadorProy creadorProy = new FrmCreadorProy();
            creadorProy.ShowDialog();
            if (FrmLogIn.usuario.rol.idRol == 2 || FrmLogIn.usuario.rol.idRol == 3)
            {
                this.ProyectosPorUsuario(FrmLogIn.usuario.id);
            }
            else
            {
                this.llenarListaProyectos();
            }
        }

        /// <summary>
        /// Elimina el proyecto 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstProyectos.SelectedItem == null)
            {
                MessageBox.Show("No hay proyectos asignados");
                return;
            }

            DialogResult dialog = MessageBox.Show("Seguro?", "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Entidades.ProyectoEnt pro = (Entidades.ProyectoEnt)this.lstProyectos.SelectedItem;
                Logica.Class.Proyecto.EliminarProy(pro.Id);

                if (FrmLogIn.usuario.rol.idRol == 2 || FrmLogIn.usuario.rol.idRol == 3)
                {
                    this.ProyectosPorUsuario(FrmLogIn.usuario.id);
                }
                else
                {
                    this.llenarListaProyectos();
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Obtiene la actividad seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvActividades_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvActividades.SelectedRows.Count > 0)
            {
                actividad = (Entidades.ActividadEnt)this.dgvActividades.SelectedRows[0].DataBoundItem;
            }
        }

        /// <summary>
        /// Menu toolStrip abre la ventana para una nueva activiadad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevaActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lstProyectos.SelectedItem == null)
            {
                MessageBox.Show("No hay proyectos asignados");
                return;
            }
            flag = false;
            FrmActividad frmAct = new FrmActividad();
            frmAct.ShowDialog();
            this.llenarTablaActividad();
            if (FrmLogIn.usuario.rol.idRol == 2 || FrmLogIn.usuario.rol.idRol == 3)
            {
                this.ProyectosPorUsuario(FrmLogIn.usuario.id);
            }
            else
            {
                this.llenarListaProyectos();
            }
        }


        /// <summary>
        /// Abre el proyecto para su modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirProyecto_Click(object sender, EventArgs e)
        {
            if (this.lstProyectos.SelectedItem == null)
            {
                MessageBox.Show("No hay proyectos asignados");
                return;
            }
            flag = true;
            FrmCreadorProy proy = new FrmCreadorProy();
            proy.ShowDialog();

        }


        private void porProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRepActPorProyectos repActProy = new Reportes.frmRepActPorProyectos();
            repActProy.Show();
        }

        private void porUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRepActPorUsuario repActPorUsuario = new Reportes.frmRepActPorUsuario();
            repActPorUsuario.Show();
        }

        private void porTipoActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRepActividadPorTipoActividad repActTipo = new Reportes.frmRepActividadPorTipoActividad();
            repActTipo.Show();
        }

        private void porProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRepUsuarioPorProyecto repUsuarPorProy = new Reportes.frmRepUsuarioPorProyecto();
            repUsuarPorProy.Show();
        }

        private void graficoActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmGrafico grafico = new Reportes.frmGrafico();
            grafico.Show();
        }

        /// <summary>
        /// Abre la ventana para una nueva Actividad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevAct_Click(object sender, EventArgs e)
        {
            if (this.lstProyectos.SelectedItem == null)
            {
                MessageBox.Show("No hay proyectos asignados");
                return;
            }
            flag = false;
            FrmActividad frmAct = new FrmActividad();
            frmAct.ShowDialog();
            this.llenarTablaActividad();
            if (FrmLogIn.usuario.rol.idRol == 2 || FrmLogIn.usuario.rol.idRol == 3)
            {
                this.ProyectosPorUsuario(FrmLogIn.usuario.id);
            }
            else
            {
                this.llenarListaProyectos();
            }
        }

        private void delUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReportUsuarioAsignado rep = new Reportes.frmReportUsuarioAsignado();
            rep.Show();
        }

        private void porGravedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRepActPorGravedad rep = new Reportes.frmRepActPorGravedad();
            rep.Show();
        }

        private void costosDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRepCostosActividades repCostos = new Reportes.frmRepCostosActividades();
            repCostos.Show();
        }


        /// <summary>
        /// Sobrecarga el metodo del close para volver a traer el frame del LogIn
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirma si el usuario quiere salir
            switch (MessageBox.Show(this, "Esta seguro de cerrar la aplicacion?", "Cerrando", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    FrmLogIn.getInstance().Show();
                    break;
            }
        }


        /// <summary>
        /// Metodo para eliminar una actividad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarAct_Click(object sender, EventArgs e)
        {
            if(actividad == null)
            {
                MessageBox.Show("No hay una actividad seleccionada");
                return;
            }
            DialogResult dialog = MessageBox.Show("Seguro?", "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                actividad = (Entidades.ActividadEnt)this.dgvActividades.SelectedRows[0].DataBoundItem;
                Logica.Class.Actividad.EliminarActividad(actividad.ID);
                this.llenarTablaActividad();
            }
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRepHistorial repHis = new Reportes.frmRepHistorial();
            repHis.Show();
        }

        private void deLosProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteActividadesProyectoAsignado repAct = new Reportes.frmReporteActividadesProyectoAsignado();
            repAct.Show();
        }
    } 
}
