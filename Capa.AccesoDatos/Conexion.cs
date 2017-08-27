using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.AccesoDatos
{
    /// <summary>
    /// Clase Importante que permite el ingreso al SQL Server
    /// </summary>
    public class Conexion
    {
        /// <summary>
        /// Variable cadena que tiene la configuracion del SQL Server
        /// </summary>
        public static string cadena
        {
            get
            {
                string nombre = "Capa.UI.Properties.Settings.Conexion";


                return System.Configuration.ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
            }
        }
    }
}
