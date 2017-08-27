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
    public partial class FrmCreadorProy : Form
    {

        int cont = Logica.Class.Proyecto.ContadorProy();
        List<Entidades.UsuarioEnt> lista = new List<Entidades.UsuarioEnt>();

        public static bool flag = false;

        public FrmCreadorProy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Da permisos y revisa la variable Flag del Menu Principal
        /// para ver si modifica o va a crear un nuevo Proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void FrmCreadorProy_Load(object sender, EventArgs e)
        {
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupbox2.BackColor = System.Drawing.Color.Transparent;
            if (FrmMenuPrincipal.flag)
            {
                this.btnCrear.Text = "Modificar";
                this.txtNombre.Text = FrmMenuPrincipal.proyecto.Nombre;
                this.NumCostoEst.Value =(decimal) FrmMenuPrincipal.proyecto.CostoHora;
                this.cboUsuarios.DataSource = Logica.Class.Usuario.listaUsuario();
                foreach(Entidades.UsuarioEnt us in Logica.Class.Proyecto.ObtenerUsuariosPorProyectos(FrmMenuPrincipal.proyecto.Id))
                {
                    lstUsuariosCont.Items.Add(us);
                }
                foreach(Entidades.UsuarioEnt us in lstUsuariosCont.Items)
                {
                    this.lista.Add(us);
                }
            }
            else
            {
                 this.llenarCombos();
                
            }
        }

        /// <summary>
        /// Llena los combos con los valores
        /// </summary>
        private void llenarCombos()
        {
            this.cboUsuarios.DataSource = Logica.Class.Usuario.listaUsuario();

         

        }

        /// <summary>
        /// Incluye al usuario a la lista de usuarios pertenecientes al proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Entidades.UsuarioEnt us= (Entidades.UsuarioEnt)this.cboUsuarios.SelectedItem;

            
            foreach(Entidades.UsuarioEnt usL in lstUsuariosCont.Items)
            {
                if (us.id == usL.id)
                {
                    MessageBox.Show("El Usuario ya se agrego, escoja otro.");
                    return;
                }
            }
            

            this.lstUsuariosCont.Items.Add(us);

        }

        /// <summary>
        /// Elimina al usuario de la lista de usuarios pertenecientes al proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
            if(lstUsuariosCont.SelectedItem == null)
            {
                MessageBox.Show("Debe escoger un usuario");
                return;
            }
            List<Entidades.UsuarioEnt> usuarList = new List<Entidades.UsuarioEnt>();
            foreach (Entidades.UsuarioEnt us in lstUsuariosCont.Items)
            {
                usuarList.Add(us);
            }


            usuarList.Remove(this.lstUsuariosCont.SelectedItem as Entidades.UsuarioEnt);

            this.lstUsuariosCont.DataSource = usuarList;
        }

        /// <summary>
        /// Crea un nuevo proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {       
            if (this.txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el Nombre");
                return;
            }

            if(this.lstUsuariosCont.Items.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un usuario");
                return;
            }
            if (this.btnCrear.Text == "Crear")
            {
                this.InsertarProyecto();
            }
            else
            {
                this.ModificarProyecto();
            }



        }

        /// <summary>
        /// Modifica el proyecto
        /// </summary>
        private void ModificarProyecto()
        {
            this.EliminarUsuarProy(this.lista);
            Entidades.ProyectoEnt proyecto = FrmMenuPrincipal.proyecto;

            proyecto.CostoHora = (double) this.NumCostoEst.Value;
            proyecto.Nombre = this.txtNombre.Text;

            Logica.Class.Proyecto.ModificarProyecto(proyecto);


            this.IncluirProyectosUsuarios();
            MessageBox.Show("Proyecto Modificado");
            this.Close();
        }

        /// <summary>
        /// Elimina de la tabla Usuarios Proyectos
        /// </summary>
        /// <param name="list"></param>
        private void EliminarUsuarProy(List<Entidades.UsuarioEnt> list)
        {
            foreach (Entidades.UsuarioEnt us in list)
            {
                Logica.Class.Proyecto.EliminarProyUsuar(FrmMenuPrincipal.proyecto.Id, us.id);
            }
        }

        private void InsertarProyecto()
        {
            Entidades.ProyectoEnt proyecto = new Entidades.ProyectoEnt();

            proyecto.Nombre = this.txtNombre.Text;
            proyecto.CostoHora = (double)this.NumCostoEst.Value;




            Logica.Class.Proyecto.InsertarProyecto(proyecto);


            ///Para obtener el Id del q se agrego
            if (cont < Logica.Class.Proyecto.ContadorProy())
            {
                this.IncluirProyectosUsuarios();
            }
            this.Close();
        }

        /// <summary>
        /// Inserta en la tabla proyecto usuarios, usando un contador para obtener el ID Consecutivo insertado
        /// </summary>
        private void IncluirProyectosUsuarios()
        {
            if (this.btnCrear.Text == "Crear")
            {
                foreach (Entidades.UsuarioEnt us in this.lstUsuariosCont.Items)
                {
                    Logica.Class.Proyecto.InsertarProyUsuar(cont + 1, us.id);
                }
            }
            else
            {
                foreach (Entidades.UsuarioEnt us in this.lstUsuariosCont.Items)
                {
                    Logica.Class.Proyecto.InsertarProyUsuar(FrmMenuPrincipal.proyecto.Id, us.id);
                }
            }
        }
    }
}
