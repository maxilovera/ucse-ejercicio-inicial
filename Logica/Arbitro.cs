﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Arbitro : Persona
    {
        public int PartidosJugados { get; set; }
        public TipoArbitro TipoArbitro { get; set; }

        public override bool ProximaARetiro()
        {
            if (Edad.HasValue)
                return Edad >= (Constantes.EdadRetiro - 2) || Edad <= (Constantes.EdadRetiro + 2);
            else
                return false;
        }
    }
}
