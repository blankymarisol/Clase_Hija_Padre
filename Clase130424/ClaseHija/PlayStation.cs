using Clase130424.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase130424.ClaseHija
{
    internal class PlayStation : ClsConsola
    {
        public string ModeloControlador { get; set; }
        public String MostrarDetallePlay()
        {
            return MostrarDetalles() + " Controlador:" + ModeloControlador;
        }

    }
}
