using System.Collections.Generic;

namespace Logica
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public int Puntos { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public List<CuerpoTecnico> CuerpoTecnico { get; set; }
    }
}