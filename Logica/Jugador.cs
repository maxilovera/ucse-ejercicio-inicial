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
        public bool EsTitular { get; set; }
        public string TitularOSuplente
        {
            get
            {
                if (this.Numero >= 1 && this.Numero <= 11) { return "Titular"; }
                return "Suplente";
            }
            set { }
        }
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }

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
