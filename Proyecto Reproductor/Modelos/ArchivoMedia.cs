using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Reproductor.Modelos
{
    internal class ArchivoMedia
    {
        public string Nombre { get; set; } = string.Empty;
        public string Ruta { get; set; } = string.Empty;
        public bool EsEncabezado { get; set; } = false;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
