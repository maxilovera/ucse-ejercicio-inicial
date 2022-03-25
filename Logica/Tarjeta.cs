using System;

namespace Logica
{
    public class Tarjeta : Incidencia
    {
        public Jugador JugadorAfectado { get; set; }
        public ColorTarjeta Color { get; set; }
        public Tarjeta TarjetaAsociada { get; set; }

        public Tarjeta(Jugador jugador, int minutoDeJuego, ColorTarjeta color, Tarjeta tarjetaAsociada)
        {
            this.JugadorAfectado = jugador;
            this.MinutoDeJuego = minutoDeJuego;
            this.Color = color;
            this.TarjetaAsociada = tarjetaAsociada;
        }

        public override string ObtenerDescripcionIncidencia()
        {
            return $"Tarjeta {this.Color.ToString() + (this.TarjetaAsociada != null ? " + ROJA" : "")} - {this.JugadorAfectado.Nombre} - {this.MinutoDeJuego}'";
        }
    }
}