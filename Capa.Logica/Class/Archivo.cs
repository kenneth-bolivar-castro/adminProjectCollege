using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Class
{
    /// <summary>
    /// Clase Archivo de la Capa Logica, Conecta el UI con los Datos
    /// </summary>
    public class Archivo
    {

        /// <summary>
        /// Accede a la capa Datos para insertar el Archivo
        /// </summary>
        /// <param name="arch"></param>
        /// <param name="idAct"></param>
        public static void InsertarArchivoAct(Entidades.ArchivoEnt arch, int idAct)
        {
            AccesoDatos.ArchivoDatos.InsertarArchivo(arch, idAct);
        }


        /// <summary>
        /// Obtiene los archivos de una actividad 
        /// </summary>
        /// <param name="IdAct"></param>
        /// <returns></returns>
        public static List<Entidades.ArchivoEnt> ObtenerArchivos(int IdAct)
        {
            return AccesoDatos.ArchivoDatos.ObtenerArchivos(IdAct);
        }

        /// <summary>
        /// Elimina el archivo perteneciente a una Actividad
        /// </summary>
        /// <param name="idArchi"></param>
        public static void ElimnarArchivo(int idArchi)
        {
            AccesoDatos.ArchivoDatos.EliminarArchivo(idArchi);
        }
    }
}
