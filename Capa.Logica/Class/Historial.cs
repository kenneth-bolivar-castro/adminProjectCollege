using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Class
{
    /// <summary>
    /// Clase Historial de la Capa Logica, Conecta el UI con los Datos
    /// </summary>
    public class Historial
    {
        /// <summary>
        /// Inserta en la tabla Historial accediendo a la Capa Datos
        /// </summary>
        /// <param name="historial"></param>
        public static void InsertarHistorial(Entidades.HistorialEnt historial)
        {
            AccesoDatos.HistorialDatos.InsertarHistorial(historial);
        }
    }
}
