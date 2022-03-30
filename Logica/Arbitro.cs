using System;
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

            int? valor = null;
            try
            {
                valor = Edad; 
            }
            catch (Exception e)
            {
                valor = null;
            }
            finally
            {
                if (valor == null)
                {
                    throw new Exception("No se seteo la edad de la persona");
                }             
            }

            return Edad >= (Constantes.EdadRetiro - 2) 
                || Edad <= (Constantes.EdadRetiro + 2);
        }
    }
}
