using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_9.ClaseBase;

namespace Clase_9.ClaseHija
{
    internal class Xbox: ClsConsola
    {
        public bool Quinet {  get; set; }
        public int Jugadores { get; set; }
        public string MostrarDetallesXb()
        {
            MostrarDetalles();
            return $"El Xbox que usted tiene cuenta con Quinet:{Quinet},Esta consola pueden usarla {Jugadores} Jugadores";
        }

    }
}
