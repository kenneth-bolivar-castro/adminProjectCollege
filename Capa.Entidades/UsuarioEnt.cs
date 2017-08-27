using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class UsuarioEnt
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public RolesEnt rol { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
