using System.Collections.Generic;

namespace Logica
{
    public class Equipo
    {
        public string Nombre { get; set; }
        // Tercer null, si el torneo no comenzo puntos es null, si empezo pero no gano ni empato tendria 0
        public int? Puntos { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public List<CuerpoTecnico> CuerpoTecnico { get; set; }
    }
}