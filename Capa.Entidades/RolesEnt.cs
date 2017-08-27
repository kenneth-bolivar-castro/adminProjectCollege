using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class RolesEnt
    {
        public int idRol { get; set; }

        public string Descrip { get; set; }

        public override string ToString()
        {
            return this.Descrip;
        }
    }
}
