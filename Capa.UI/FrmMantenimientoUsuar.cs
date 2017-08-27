
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI
{
    public partial class FrmMantenimientoUsuar : Form
    {
        /// <summary>
        /// Variable ocupada para el Id en modificar y eliminar
        /// </summary>
        int id = 0;
        public FrmMantenimientoUsuar()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Dedazo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Carga todo lo necesario para el mantenimiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMantenimientoUsuar_Load(object sender, EventArgs e)
        {
            this.refrescar();
            this.cargarCombo();
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.ClearSelection();
            this.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Text = "");
            this.cboRol.SelectedIndex = -1;
        }


        /// <summary>
        /// Regresca el DataGridView
        /// </summary>
        private void refrescar()
        {
            try
            {
                this.dgvUsuarios.DataSource = Logica.Class.Usuario.listaUsuario();
            }
            catch(ApplicationException)
            {
                MessageBox.Show("Error SQL");
            }
        }


        /// <summary>
        /// Obtiene los Roles del combo
        /// </summary>
        private void cargarCombo()
        {
            this.cboRol.DataSource = Logica.Class.Roles.ObtenerListaRoles();
        }


        /// <summary>
        /// Inserta un nuevo usuario en la tabla Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(this.txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el Nombre");
                return;
            }
            if(this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el Nombre de usuario");
                return;
            }
            if(this.txtContra.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una contraseña para el usuario");
                return;
            }

            if(this.cboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe escoger un Rol");
                return;
            }
            if (this.email_bien_escrito(this.txtUsuario.Text)) {


                Entidades.UsuarioEnt usuario = new Entidades.UsuarioEnt();

                usuario.Nombre = this.txtNombre.Text;
                usuario.NombreUsuario = this.txtUsuario.Text;
                usuario.Contrasenia = this.txtContra.Text;
                Entidades.RolesEnt rol = this.cboRol.SelectedItem as Entidades.RolesEnt;
                usuario.rol = rol;

                Logica.Class.Usuario.insertarUsuario(usuario);

                this.refrescar();
            }
            else
            {
                MessageBox.Show("Debe ingresar un correo valido. Ej: correo@gmail.com");
                return;
            }



        }

        /// <summary>
        /// Modifica al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el Nombre");
                return;
            }
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el Nombre de usuario");
                return;
            }
            
            if (this.cboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe escoger un Rol");
                return;
            }
            Entidades.UsuarioEnt usuario = new Entidades.UsuarioEnt();
            usuario.id = this.id;
            usuario.Nombre = this.txtNombre.Text;
            usuario.NombreUsuario = this.txtUsuario.Text;
            usuario.rol = this.cboRol.SelectedItem as Entidades.RolesEnt;
            Logica.Class.Usuario.modificarUsuario(usuario);
            this.refrescar();




        }

        /// <summary>
        /// Cambia los valores de los txt y demas a los pertenecientas al usuario
        /// seleccionado en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                //var es una palabra clave u objeto que acepta todas las clases,
                //si se castea, el objeta se crea del tipo casteado
                var usuar = (Entidades.UsuarioEnt)dgvUsuarios.SelectedRows[0].DataBoundItem;
                //Actualizar los valores
                //Llama a la variable Id
                this.id = usuar.id;
                this.txtNombre.Text = usuar.Nombre;
                this.txtUsuario.Text = usuar.NombreUsuario;
                this.cboRol.SelectedIndex = this.cboRol.FindStringExact(usuar.rol.ToString());
                this.btnEliminar.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnGuardar.Enabled = false;

                
            }
        }

        /// <summary>
        /// Elimina al usuario preguntandole si esta seguro o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Seguro?", "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Logica.Class.Usuario.eliminarUsuario(this.id);
                    this.refrescar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario");
            }
        }

        /// <summary>
        /// Dedazo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Se limpia el frame para que pueda escribir de nuevo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMantenimientoUsuar_Click(object sender, EventArgs e)
        {
            this.dgvUsuarios.ClearSelection();
            this.btnGuardar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Text = "");
            this.cboRol.SelectedIndex = -1;
        }

        /// <summary>
        /// Revisa que email este bien escrito osea, que pertenezca por ejemplo
        /// a gmail.com
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
