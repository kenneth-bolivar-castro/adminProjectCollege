
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Class
{

    /// <summary>
    /// ClaseProyecto de la Capa Logica, Conecta el UI con los Datos
    /// </summary>
    public class Proyecto
    {
        /// <summary>
        /// Propiedades clase proyecto
        /// </summary>
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public double CostoTotal { get; set; }
        public int TotalHoras { get; set; }
        public List<Actividad> ListaActividades { get; set; }
        public List<Usuario> ListaUsuarios { get; set; }


        /// <summary>
        /// Define el costo por hora y se hace el calculo
        /// </summary>
        public static readonly double CostoHora = 30;


        /// <summary>
        /// Constructor
        /// </summary>
        public Proyecto()
        {
            this.ListaUsuarios = new List<Usuario>();
            this.ListaActividades = new List<Actividad>();

        }


        /// <summary>
        /// Llama al metodo de la capa de datoso obtenerProyectos
        /// </summary>
        /// <returns>Retorna lista Tipo Entidades.Proyecto</returns>
        public static List<Entidades.ProyectoEnt> ObtenerProyectos()
        {
            return AccesoDatos.ProyectosDatos.ObtenerTodosProyectos();
        }

        /// <summary>
        /// Obtiene los Usuarios asignados A un Proyecto
        /// </summary>
        /// <param name="idproy">Id del proyecto para Obtenerlos</param>
        /// <returns></returns>
        public static List<Entidades.UsuarioEnt> ObtenerUsuariosPorProyectos(int idproy)
        {
            return AccesoDatos.ProyectosDatos.ObtenerTodosUsuariosPorProyetos(idproy);
        }

        /// <summary>
        /// Obtiene los Proyectos asignados a un Usuario
        /// </summary>
        /// <param name="idusuar">Id del Usuario</param>
        /// <returns></returns>
        public static List<Entidades.ProyectoEnt> ObtenerProyectosPorUsuarios(int idusuar)
        {
            return AccesoDatos.ProyectosDatos.ObtenerTodosProyectosPorUsuarios(idusuar);
        }


        /// <summary>
        /// Comunica con AccesoDatos para insertar el proyecto Creado
        /// </summary>
        /// <param name="proyecto"></param>
        public static void InsertarProyecto(Entidades.ProyectoEnt proyecto)
        {
            AccesoDatos.ProyectosDatos.InsertarProyecto(proyecto);
        }

        public override string ToString()
        {
            return this.Nombre;
        }

        /// <summary>
        /// Inserta en la tabla UsuariosProyectos ambos ID's
        /// </summary>
        /// <param name="IdProy"></param>
        /// <param name="IdUsr"></param>
        public static void InsertarProyUsuar(int IdProy,int IdUsr)
        {
            AccesoDatos.ProyectosDatos.InsertarTablaProyUsuarios(IdProy,IdUsr);
        }


        /// <summary>
        /// Obtiene la cantidad de proyectos, para saber el ID siguiente
        /// </summary>
        /// <returns></returns>
        public static int ContadorProy()
        {
            return AccesoDatos.ProyectosDatos.ContadorProycts();
        }

        /// <summary>
        /// Eliminar el proyecto accediendo a Capa.AccesoDatos
        /// </summary>
        /// <param name="id"></param>
        public static void EliminarProy(int id)
        {
            AccesoDatos.ProyectosDatos.EliminarProyecto(id);
        }


        /// <summary>
        /// Modifica al proyecto
        /// </summary>
        /// <param name="proyecto"></param>
        public static void ModificarProyecto(Entidades.ProyectoEnt proyecto)
        {
            AccesoDatos.ProyectosDatos.ModificarProyecto(proyecto);
        }


        /// <summary>
        /// Elimina de la tabla UsuariosProyectos
        /// </summary>
        /// <param name="IdProy"></param>
        /// <param name="IdUsr"></param>
        public static void EliminarProyUsuar(int IdProy,int IdUsr)
        {
            AccesoDatos.ProyectosDatos.EliminarUsuariosProyecto(IdProy, IdUsr);
        }

        

    }
}
