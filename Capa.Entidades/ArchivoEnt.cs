﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class ArchivoEnt
    {
        public int Id { get; set; }
        public byte[] ArrByte { get; set; }
        public string Nombre { get; set; }



        public override string ToString()
        {
            return Nombre;
        }
    }
}
