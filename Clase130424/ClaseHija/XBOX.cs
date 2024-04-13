using Clase130424.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase130424.ClaseHija
{
    internal class XBOX : ClsConsola
    {
        public bool TieneHalo { get; set; }
        public String MostrarDetalleXBOX()
        {
            return MostrarDetalles() + " Tiene Halo:" + TieneHalo;
        }
    }
}

