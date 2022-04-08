using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public partial class Equipo
    {
        public decimal? Presupuesto { get; private set; }
        public bool AsignarPresupuesto()
        {
            bool resultado = false;
            decimal total = 0;
            if (this.Presupuesto == null)
            {
                total += (this.Jugadores.Count + 1) * 15000;
                foreach (CuerpoTecnico item in this.CuerpoTecnico)
                {
                    if (item.EsTecnicoPrincipal == true)
                    {
                        total += 30000;
                    }
                    else
                    {
                        total += 10000;
                    }
                }
            }
            return resultado;
        }
    }
}
