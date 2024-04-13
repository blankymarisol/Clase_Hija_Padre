using Clase130424.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase130424.ClaseHija
{
    internal class Nintendo : ClsConsola
    {
        public bool esPortable { get; set; }
        public string MostrarDetalleNintendo()
        {
            string detallePadre = MostrarDetalles();
            return detallePadre + " Es portable: " + esPortable;
        }
    }
}

