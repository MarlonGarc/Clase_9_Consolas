using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_9.ClaseBase;

namespace Clase_9.ClaseHija
{
    internal class Nintendo : ClsConsola
    {
        public bool EsPortatil { get; set; }
        public string MostrarDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es Portatil: {EsPortatil}";
        }
    }
}
