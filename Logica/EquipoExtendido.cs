using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public partial class Equipo
    {
        public int Presupuesto { get; private set; }

        const int porJugador = 15000;
        const int porEntrenador = 30000;
        const int porCuerpoTecnico = 10000;

        public bool DineroNecesario()
        {
            int presupuestoTotal = Jugadores.Count() * porJugador;

            foreach (CuerpoTecnico item in CuerpoTecnico)
            {
                presupuestoTotal = item.EsTecnicoPrincipal == true
                                         ? presupuestoTotal += porEntrenador
                                         : presupuestoTotal += porCuerpoTecnico;
            }

            if (presupuestoTotal != null)
            {
                Presupuesto = presupuestoTotal;
                return true;
            }
            return false;
        }
    }
}
