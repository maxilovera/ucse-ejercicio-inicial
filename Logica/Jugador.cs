using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Jugador : Persona
    {
        public int? NumeroDeCamiseta { get; set; }
        public bool? EsTitular { get { return EsTitular; }
            set
            {
                if (NumeroDeCamiseta.HasValue)
                    if(NumeroDeCamiseta.Value<=11 && NumeroDeCamiseta.Value >= 1)
                        EsTitular = true;
                    else
                        EsTitular=false;
            } }
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }

        public override bool ProximaARetiro()
        {
            if (Edad.HasValue)
                return Edad >= (Constantes.EdadRetiro - 2) || Edad <= (Constantes.EdadRetiro + 2);
            else
                return false;
        }
    }
}
