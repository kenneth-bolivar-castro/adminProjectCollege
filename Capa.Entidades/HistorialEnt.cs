using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class HistorialEnt
    {
        public DateTime FechaCambio { get; set; }
        public string TipoCambio { get; set; }
        public ActividadEnt actividad { get; set; }
        public UsuarioEnt usuario { get; set; }
         
    }
}
