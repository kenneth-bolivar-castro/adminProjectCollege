
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Class
{
    /// <summary>
    /// Clase Usuario de la Capa Logica, Conecta el UI con los Datos
    /// </summary>
    public class Usuario
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public Roles Rol { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }


        /// <summary>
        /// Regresa la lista de usuarios de la Base de Datos
        /// </summary>
        /// <returns></returns>
        public static List<Entidades.UsuarioEnt> listaUsuario()
        {

            List<Entidades.UsuarioEnt> lista = AccesoDatos.UsuariosDatos.ObtenerTodosUsuarios();

            if (lista == null)
                throw new ApplicationException();

            return lista;

        }
        /// <summary>
        /// Valida si el usuario ya existe, para editarlo o insertarlo
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static void insertarUsuario(Entidades.UsuarioEnt us)
        {
          
            AccesoDatos.UsuariosDatos.InsertarUsuario(us);
        }

        /// <summary>
        /// Metodo para Modificar, utilizando capas
        /// </summary>
        /// <param name="usuario"></param>
        public static void modificarUsuario(Entidades.UsuarioEnt usuario)
        {
           
            AccesoDatos.UsuariosDatos.modificar(usuario);
        }

        /// <summary>
        /// Elimina al usuario
        /// </summary>
        /// <param name="id"></param>
        public static void eliminarUsuario(int id)
        {
            AccesoDatos.UsuariosDatos.EliminarUsuario(id);
        }


        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
