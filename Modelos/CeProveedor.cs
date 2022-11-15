﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    internal class CeProveedor
    {
        public int ID { get; set; }
        public int IDProveedor { get; set; }
        public string CodigoCiudad { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
        public string Producto { get; set; }
        public string Estatus { get; set; }
        public byte[] Foto { get; set; }
    }
}
