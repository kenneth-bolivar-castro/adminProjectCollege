using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI
{
    public partial class FrmActividad : Form
    {

        /// <summary>
        /// Variable Activiad utilizada en distintas partes 
        /// </summary>
        private Entidades.ActividadEnt actividad;


        public FrmActividad()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Da los permisos al usuario loggeado
        /// </summary>
        private void Permisos()
        {
            if(FrmLogIn.usuario.rol.idRol == 1)
            {
                this.txtNombre.Enabled = true;
                this.txtDescrip.Enabled = true;
                this.cboEstado.Enabled = true;
                this.numEstimado.Enabled = true;
                this.numGravedad.Enabled = true;
                this.numHrsTrabajadas.Enabled = true;
                this.btnAjuntar.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.cboTipoAct.Enabled = true;
                this.cboUsuarios.Enabled = true;
            }
            else
            {
                if(FrmLogIn.usuario.rol.idRol == 2)
                {
                    this.txtNombre.Enabled = true;
                    this.txtDescrip.Enabled = true;
                    this.cboEstado.Enabled = true;
                    this.numEstimado.Enabled = true;
                    this.numGravedad.Enabled = true;
                    this.numHrsTrabajadas.Enabled = true;
                    this.btnAjuntar.Enabled = true;
                    this.btnGuardar.Enabled = true;
                    this.cboTipoAct.Enabled = true;
                    this.cboUsuarios.Enabled = true;
                }
                else
                {
                    this.txtNombre.Enabled = false;
                    this.txtDescrip.Enabled = false;
                    this.cboEstado.Enabled = true;
                    this.numEstimado.Enabled = false;
                    this.numGravedad.Enabled = false;
                    this.numHrsTrabajadas.Enabled = true;
                    this.btnAjuntar.Enabled = true;
                    this.btnGuardar.Enabled = true;
                    this.cboTipoAct.Enabled = false;
                    this.cboUsuarios.Items.Add(FrmMenuPrincipal.actividad.Usuario);
                    this.cboUsuarios.SelectedIndex = 0;
                    this.cboUsuarios.Enabled = false;
                    
                }
            }

        }

        private void frmProyectos_Load(object sender, EventArgs e)
        {
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.Permisos();
            this.llenarCombos();
            ///Verifica si ingreso con una actividad seleccionada o si va
            ///a generar una nueva actividad
            if (FrmMenuPrincipal.flag)
            {
                this.btnGuardar.Text = "Modificar";
                actividad = FrmMenuPrincipal.actividad;
                this.txtNombre.Text = FrmMenuPrincipal.actividad.Titulo;
                this.txtDescrip.Text = FrmMenuPrincipal.actividad.Detalles;
                this.cboEstado.SelectedItem = FrmMenuPrincipal.actividad.Estado;
                this.numEstimado.Value = FrmMenuPrincipal.actividad.TiempoEstimado;
                this.numHrsTrabajadas.Value = FrmMenuPrincipal.actividad.TiempoReal;
                this.numGravedad.Value = FrmMenuPrincipal.actividad.Gravedad;
                this.cboTipoAct.SelectedItem = FrmMenuPrincipal.actividad.Tipo;
                this.cboUsuarios.SelectedIndex = this.cboUsuarios.FindStringExact(FrmMenuPrincipal.actividad.Usuario.ToString());
                this.llenarLista();
            }
            else
            {
                actividad = new Entidades.ActividadEnt();
            }
            

        }


        /// <summary>
        /// Llena la lista por me dio del metodo .add para ser modificado
        /// </summary>
        private void llenarLista()
        {
            List<Entidades.ArchivoEnt> listArch = 
            Logica.Class.Archivo.ObtenerArchivos(FrmMenuPrincipal.actividad.ID);
            foreach(Entidades.ArchivoEnt arch in listArch)
            {
                this.lstArchivos.Items.Add(arch);
            }

        }

        /// <summary>
        /// Llena los combos actualizandolos
        /// </summary>
        private void llenarCombos()
        {
            this.cboUsuarios.DataSource = Logica.Class.Proyecto.ObtenerUsuariosPorProyectos(FrmMenuPrincipal.proyecto.Id);
            this.cboTipoAct.DataSource = Logica.Class.Actividad.ObtenerListaTipoAct();


            string[] arrEst = new string[3];

            arrEst[0] = "Nuevo";
            arrEst[1] = "Trabajando";
            arrEst[2] = "Terminado";

            this.cboEstado.DataSource = arrEst;
        }
        /// <summary>
        /// Adjunta archivos a la actividad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.openFileDialog1.Filter = "All files (*.*)|*.*";
                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    Entidades.ArchivoEnt archivo = new Entidades.ArchivoEnt();
                    ///Inicializa el objeto archivo, solamente si le da OK
                    string ruta = this.openFileDialog1.FileName;
                    //Obtiene con la clase Path el nombre del archivo
                    archivo.Nombre = Path.GetFileName(ruta);
                    //Obtiene los bytes del archivo con la clase File
                    archivo.ArrByte = File.ReadAllBytes(ruta);

                    actividad.listArchivos.Add(archivo);
                    this.lstArchivos.Items.Add(archivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///     Boton guardar, dentro decide si modifica o inserta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            if (this.txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Nombre a la Actividad");
                return;
            }
            if (this.txtDescrip.Text == String.Empty)
            {
                MessageBox.Show("Ingrese una descripcion");
                return;
            }
            if (this.cboEstado.SelectedItem == null)
            {
                MessageBox.Show("Escoja un estado a la Actividad");
                return;
            }


            this.GuardarAct();
            this.GuardarHistorial();
            this.Close();


        }

        /// <summary>
        /// Guarda en la tabla historial los cambios
        /// </summary>
        private void GuardarHistorial()
        {
            Entidades.HistorialEnt historial = new Entidades.HistorialEnt();

            historial.FechaCambio = DateTime.Now;
            historial.actividad = actividad;
            if(this.btnGuardar.Text == "Guardar")
            {
                historial.TipoCambio = "Se agrego una nueva activdad";
            }
            else
            {
                historial.TipoCambio = "Se modifico una actividad";
            }
            
            historial.usuario = new Entidades.UsuarioEnt();
            historial.usuario.id = FrmLogIn.usuario.id;

            Logica.Class.Historial.InsertarHistorial(historial);

        }



        /// <summary>
        /// Guarda la actividad revisa si se va a modificar o crear uno nuevo y si tiene archivos en el
        /// </summary>
        private void GuardarAct()
        {
            int cont = Logica.Class.Actividad.ContadorDeActividades();
            //Asigna valores al objeto actividad
            actividad.Titulo = this.txtNombre.Text;
            actividad.Detalles = this.txtDescrip.Text;
            actividad.TiempoEstimado = (int)this.numEstimado.Value;
            actividad.TiempoReal = (int)this.numHrsTrabajadas.Value;
            actividad.Usuario = (Entidades.UsuarioEnt)this.cboUsuarios.SelectedItem;
            actividad.Estado = this.cboEstado.SelectedItem as String;
            actividad.Gravedad = (int)this.numGravedad.Value;
            actividad.Tipo = (Entidades.TipoActividad)this.cboTipoAct.SelectedItem;


            //Verifica si hay Archivos adjuntos
            if (actividad.listArchivos.Count == 0)
            {
                //Verifica si va a crear uno nuevo
                if (this.btnGuardar.Text.Equals("Guardar")){
                    this.EnviarEmail();
                    Logica.Class.Actividad.InsertarActividad(actividad, FrmMenuPrincipal.proyecto);
                    actividad.ID = cont + 1;
                }
                //Sino es q va a modificar
                else
                {
                    Logica.Class.Actividad.ModificarActividad(actividad,FrmMenuPrincipal.proyecto);
                }
               
            }
            else
            //Sino es q existen archivos adjuntos
            {
                Logica.Class.Actividad.InsertarActividad(actividad, FrmMenuPrincipal.proyecto);
                //Verifica si va a crear una nueva actividad
                if (this.btnGuardar.Text.Equals("Guardar"))
                {
                    this.EnviarEmail();
                    Logica.Class.Actividad.InsertarActividad(actividad, FrmMenuPrincipal.proyecto);
                    actividad.ID = cont + 1;

                }
                //Sino es q va a modificar una
                else
                {
                    Logica.Class.Actividad.ModificarActividad(actividad,FrmMenuPrincipal.proyecto);
                }

                //Este pregunta si se inserto algo y si se inserto, usar el contador
                //como ID ya que es consecutivo se le suma 1, Para insertar los archivos
                //en la tabla
                if (cont < Logica.Class.Actividad.ContadorDeActividades())
                {
                    foreach (Entidades.ArchivoEnt archivo in actividad.listArchivos)
                    {
                        Logica.Class.Archivo.InsertarArchivoAct(archivo, cont + 1);

                    }
                }
                //Si no es q va a usar el ID de la actividad por modificar
                else
                {
                    foreach (Entidades.ArchivoEnt archivo in actividad.listArchivos)
                    {
                        Logica.Class.Archivo.InsertarArchivoAct(archivo, actividad.ID);
                    }
                }
            }
        } 

        /// <summary>
        /// Dedazo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo para Enviar Correo electronico SmtpClient
        /// </summary>
        private void EnviarEmail()
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(actividad.Usuario.NombreUsuario));
            email.From = new MailAddress("adminproyectos@enterprise.com");
            email.Subject = "Asunto ( " + DateTime.Now.ToShortDateString() + " ) Tiene una nueva actividad";
            email.Body = actividad.Detalles;


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("kvn2794@gmail.com", "bolitress3");


            try
            {
                smtp.Send(email);
                email.Dispose();
                MessageBox.Show("Usuario Notificado");

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo notificar al usuario");
            }


             
        }

        ///TODO: Eliminar Archivos
        /// <summary>
        /// Metodo para abrir los archivos usando la clase FileStream y abre el archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if(this.lstArchivos.SelectedItem == null)
            {
                MessageBox.Show("Debe escoger un archivo");
                return;
            }
            //try
            //{
              
            //    this.saveFileDialog1.Filter = "All files | *.file";
            //    DialogResult dr = this.ShowDialog();

            //    if (dr == System.Windows.Forms.DialogResult.OK)
            //    {
            //        string ruta = this.saveFileDialog1.FileName;

            //    }
            //}
            //catch
            //{

            //    throw;
            //}


            Entidades.ArchivoEnt arch = this.lstArchivos.SelectedItem as Entidades.ArchivoEnt;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileStream fs = new FileStream(path+@"\"+arch.Nombre, FileMode.Create);
            fs.Write(arch.ArrByte, 0, arch.ArrByte.Length);
            fs.Close();
            System.Diagnostics.Process.Start(path+@"\" + arch.Nombre);


        }

        /// <summary>
        /// Metodo para eliminar un archivo de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(this.lstArchivos.Items.Count == 0)
            {
                MessageBox.Show("No hay archivos en la lista");
                return;
            }

            Entidades.ArchivoEnt arch = this.lstArchivos.SelectedItem as Entidades.ArchivoEnt;
            if(arch == null)
            {
                MessageBox.Show("No ha escogido ningun archivo");
                return;
            }

            this.lstArchivos.Items.Remove(arch);

            Logica.Class.Archivo.ElimnarArchivo(arch.Id);

        }
    }
}
