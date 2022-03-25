using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Gol : Incidencia
    {
        public Jugador Jugador { get; set; }
        public bool EsEnContra { get; set; }
        public bool EsArcoLocal { get; set; }

        public Gol(Jugador jugador, bool esEnContra, int minutoDeJuego, bool esArcoLocal)
        {
            this.Jugador = jugador;
            this.EsEnContra = esEnContra;
            this.MinutoDeJuego = minutoDeJuego;
            this.EsArcoLocal = esArcoLocal;
        }

        public override string ObtenerDescripcionIncidencia()
        {
            return $"GOL - {this.Jugador.Equipo.Nombre.ToUpper()} - {this.Jugador.Nombre.ToUpper() + (this.EsEnContra ? " (EC)" : "")} - {this.MinutoDeJuego}'";
        }
    }
}
