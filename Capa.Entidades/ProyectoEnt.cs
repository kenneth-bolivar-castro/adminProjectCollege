using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class ProyectoEnt
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public double TotCosto { get; set; }
        public int TiempoTotalTrab { get; set; }
        public List<UsuarioEnt> ListUsuarios { get; set; }
        public List<ActividadEnt> listActividades { get; set; }
        public double EstimCosto { get; set; }
        public int TiempoEstimTrab { get; set; }
        public double CostoHora { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }





    }
}
