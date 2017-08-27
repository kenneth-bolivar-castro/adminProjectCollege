using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
      public class ActividadEnt
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Detalles { get; set; }
        public int TiempoEstimado { get; set; }
        public int TiempoReal { get; set; }
        public double CostoActividad { get; set; }
        public UsuarioEnt Usuario { get; set; }
        public string Estado { get; set; }
        public int Gravedad { get; set; }
        public double CostoEstActividad { get; set; }
        
        public TipoActividad Tipo { get; set; }
        public List<ArchivoEnt> listArchivos { get; set; }

        public ActividadEnt()
        {
            this.listArchivos = new List<ArchivoEnt>();
        }

    }
}
