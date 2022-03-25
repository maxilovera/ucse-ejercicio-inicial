using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Arbitro : Persona
    {
        public TipoArbitro TipoArbitro { get; set; }

        public override bool ProximaARetiro()
        {
            return Edad >= (Constantes.EdadRetiro - 2) || Edad <= (Constantes.EdadRetiro + 2);
        }
    }
}
