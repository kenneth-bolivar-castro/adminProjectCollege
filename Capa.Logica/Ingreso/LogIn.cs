using Capa.Logica.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Ingreso
{
    /// <summary>
    /// Clase LogIn de la Capa Logica, Conecta el UI con los Datos,
    /// valida al usuario y lo deja ingresar al sistema
    /// </summary>
    public class LogIn
    {
        /// <summary>
        /// Ingreso al sistema validando el usuario
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contra"></param>
        /// <returns></returns>
        public static Entidades.UsuarioEnt ingreso(string nombreUsuario,string contra)
        {


            Entidades.UsuarioEnt ent = AccesoDatos.IngresoProgr.ingreso(nombreUsuario, contra);
           

            if(ent == null)
            {
                throw new ApplicationException();
            }
            return ent;
            
        }

       
    }
}
