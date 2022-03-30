using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Arbitro : Persona
    {
        public int? PartidosJugados { get; set; }
        public TipoArbitro TipoArbitro { get; set; }

        public override bool ProximaARetiro()
        {
            if (this.Edad == null)
            {
                throw new Exception("Se produjo un error (Edad = null)");
            }
            return Edad >= (Constantes.EdadRetiro - 2) 
                || Edad <= (Constantes.EdadRetiro + 2);
        }
    }
}
