using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Class
{
    /// <summary>
    /// Clase Actividad de la Capa Logica, Conecta el UI con los Datos
    /// </summary>
    public class Actividad
    {

        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Detalles { get; set; }
        public int TiempoEstimado { get; set; }
        public int TiempoReal { get; set; }
        public double CostoActividad { get; set; }
        public string Estado { get; set; }
        public int Gravedad { get; set; }
        public double CostoEstActividad { get; set; }



        /// <summary>
        /// Obtiene la lista de Actividades POR proyecto
        /// </summary>
        /// <param name="idproy"></param>
        /// <returns></returns>
        public static List<Entidades.ActividadEnt> ObtenerListaPorProyecto(int idproy)
        {
            return AccesoDatos.ActividadDatos.ObtenerListaActPorProyectos(idproy);
        }

        /// <summary>
        /// Metodo para obtener la lista de Tipo De Actividad
        /// </summary>
        /// <returns></returns>
        public static List<Entidades.TipoActividad> ObtenerListaTipoAct()
        {
            return AccesoDatos.ActividadDatos.ObtenerTipoActividad();
        }

        /// <summary>
        /// Metodo que regresa la cantidad de actividades, para obtener el Id siguiente
        /// </summary>
        /// <returns></returns>
        public static int ContadorDeActividades()
        {
            return AccesoDatos.ActividadDatos.ContadorActividades();
        }

        /// <summary>
        /// Inserta la actividad a la tabla
        /// </summary>
        /// <param name="actividad"></param>
        /// <param name="IDProy"></param>
        public static void InsertarActividad(Entidades.ActividadEnt actividad,Entidades.ProyectoEnt proy)
        {
            actividad.CostoActividad = calcularCostoActividad(actividad, proy);
            actividad.CostoEstActividad = calcularEstimadoCostoActividad(actividad,proy);
            AccesoDatos.ActividadDatos.InsertarActividad(actividad, proy);
        }


        /// <summary>
        /// Modifica la actividad en la tabla
        /// </summary>
        /// <param name="act"></param>
        public static void ModificarActividad(Entidades.ActividadEnt act,Entidades.ProyectoEnt proy)
        {
            act.CostoActividad = calcularCostoActividad(act, proy);
            act.CostoEstActividad = calcularEstimadoCostoActividad(act,proy);
            AccesoDatos.ActividadDatos.ModificarActividad(act);
        }

        /// <summary>
        /// Calcula el monto estimado de la actividad
        /// </summary>
        /// <param name="act"></param>
        /// <returns></returns>
        private static double calcularEstimadoCostoActividad(Entidades.ActividadEnt act, Entidades.ProyectoEnt proy)
        {
            return act.TiempoEstimado * proy.CostoHora;
        }

        /// <summary>
        /// Calcula el costo Real de la actividad
        /// </summary>
        /// <param name="act">Parametro actividad para obtener el tiempo real</param>
        /// <param name="proy">Parametro proy para obtener el costo de la hora</param>
        /// <returns></returns>
        private static double calcularCostoActividad(Entidades.ActividadEnt act,Entidades.ProyectoEnt proy)
        {
            return act.TiempoReal * proy.CostoHora;
        }
    }
}
