using System.Collections.Generic;
using System;

namespace Logica
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public Nullable<int> Puntos { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public List<CuerpoTecnico> CuerpoTecnico { get; set; }
    }
}