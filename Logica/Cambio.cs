namespace Logica
{
    public class Cambio : Incidencia
    {
        public Jugador JugadorEntrante { get; set; }
        public Jugador JugadorSaliente { get; set; }

        public override string ObtenerDescripcionIncidencia()
        {
            return $"Cambio {this.JugadorEntrante.Nombre} x {this.JugadorSaliente.Nombre} - {this.MinutoDeJuego}'";
        }
    }
}