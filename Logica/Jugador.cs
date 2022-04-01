using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Jugador : Persona
    {
        public Nullable<int> Numero { get; set; }
        public string EsTitular
        {
            get {
                if (Numero.HasValue)
                {
                    if (Numero.Value >= 1)
                    {
                        return "es titular";
                    }
                    else
                    {
                        return "no es titular";
                    }
                }
                else
                {
                    return "no tiene numero";   
                }
            } }
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }

        public override bool ProximaARetiro()
        {
            if (Edad.HasValue)
            {
                return Edad >= (Constantes.EdadRetiro - 2)
                || Edad <= (Constantes.EdadRetiro + 2);
            }
            else
            {
                throw new Exception("Edad es null");
            }
        }
    }
}
