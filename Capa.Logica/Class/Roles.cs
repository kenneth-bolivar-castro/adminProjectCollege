using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Class
{
    /// <summary>
    /// Clase Roles de la Capa Logica, Conecta el UI con los Datos
    /// </summary>
    public class Roles
    {

        /// <summary>
        /// Obtiene los Roles Existentes
        /// </summary>
        /// <returns></returns>
        public static List<Entidades.RolesEnt> ObtenerListaRoles()
        {
            return AccesoDatos.RolesDatos.ObtenerListaRoles();
        }

    }
}
