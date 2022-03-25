using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Incidencia
    {
        public int MinutoDeJuego { get; set; }

        public abstract string ObtenerDescripcionIncidencia();
    }
}
