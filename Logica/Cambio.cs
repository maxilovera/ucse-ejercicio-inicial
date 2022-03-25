namespace Logica
{
    public class Cambio : Incidencia
    {
        public Jugador JugadorEntrante { get; set; }
        public Jugador JugadorSaliente { get; set; }

        public override string ObtenerDescripcionIncidencia()
        {
            return $"Cambio {this.JugadorSaliente.Nombre} x {this.JugadorEntrante.Nombre} - {this.MinutoDeJuego}'";
        }
    }
}