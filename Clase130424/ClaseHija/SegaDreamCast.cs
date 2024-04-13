using Clase130424.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase130424.ClaseHija
{
    internal class SegaDreamCast : ClsConsola
    {
        public bool ControlconPantallita { get; set; }
        public string MostrarDetalleSega()
        {
            return MostrarDetalles() + "El control tiene pantallita: " + ControlconPantallita;
        }
    }
}