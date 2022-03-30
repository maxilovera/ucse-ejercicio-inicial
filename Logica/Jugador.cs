using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Jugador : Persona
    {
        public int Numero { get; set; }
        public bool? EsTitular 
        {
            get
            {
                return EsTitular;
            } 
            set 
            {
                if (Numero > 0 || Numero < 12)
                {
                    EsTitular = true;
                }
                else
                {
                    EsTitular = false;
                }
            }
        }
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }

        public override bool ProximaARetiro()
        {
            return Edad >= (Constantes.EdadRetiro - 2) 
                || Edad <= (Constantes.EdadRetiro + 2);
        }
    }
}
