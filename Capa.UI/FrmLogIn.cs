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
    public partial class FrmLogIn : Form
    {  /// <summary>
       /// Variable static usuario que va a ser transmitida a los frames
       /// </summary>
        public static Entidades.UsuarioEnt usuario = null;
        
        /// <summary>
        ///El form usa el patron Singleton para que asi se cree solamente uno 
        /// </summary>
        public static FrmLogIn instance = null;

        /// <summary>
        /// Constructor privado
        /// </summary>
        private FrmLogIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo statico para obtener instancia
        /// </summary>
        /// <returns></returns>
        public static FrmLogIn getInstance()
        {
            if(instance == null)
            {
                instance = new FrmLogIn();
                return instance;
            }
            return instance;
        }

        


        private void btnIngresar_Click(object sender, EventArgs e)
        {
                try
            {
                
                    usuario = Logica.Ingreso.LogIn.ingreso(this.txtUsuario.Text, this.txtContra.Text);
                    FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                    this.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Text = "");
                    frmMenu.Show();
                    this.Hide();
                }
               
            catch (ApplicationException)
            {
                MessageBox.Show("El usuario no existe, intentelo de nuevo");
                this.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Text = "");
            }
            
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            
        }
    }
}
