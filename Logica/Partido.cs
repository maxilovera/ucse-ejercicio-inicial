using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Partido 
    {
        //Crear una clase principal para registrar los datos de un partido determinado
        public List<Arbitro> Arbitros { get; set; }
        //Punto 3 : es necesario modificar el metodo de crear un partido, ya que
        //al hacer privado el set solo puedo darle valor desde la clase Partido.
        public string Ciudad { get; private set; }
        public DateTime InicioPartido { get; set; }
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public List<Gol> Goles { get; set; }
        public short TiempoDeJuego { get {return RetornarMinutoJuego();} }
        public List<Cambio> Cambios { get; set; }
        public List<Tarjeta> Tarjetas { get; set; }

        public Partido() { }
        public Partido(List<Arbitro> arbitros, string ciudad, Equipo equipoLocal, Equipo equipoVisitante)
        {
            this.Arbitros = arbitros;
            this.Ciudad = ciudad;
            this.EquipoLocal = equipoLocal;
            this.EquipoVisitante = equipoVisitante;
        }
        ~Partido()
        {
            Arbitros.Clear();
            Cambios.Clear();
            Tarjetas.Clear();
            Goles.Clear();
        }
        public void AgregarIncidencia(Gol gol)
        {
            this.Goles.Add(gol);
            
        }

        public void AgregarIncidencia(Cambio cambio)
        {
            this.Cambios.Add(cambio);
        }

        public void AgregarIncidencia(Tarjeta tarjeta)
        {
            Tarjeta tarjetaPrevia = ObtenerIncidenciaPrevia(tarjeta);

            if (tarjetaPrevia != null) {
                tarjeta.TarjetaAsociada = tarjetaPrevia;
            }

            this.Tarjetas.Add(tarjeta);
        }

        //Opcion para agregar incidencia
        private Tarjeta ObtenerIncidenciaPrevia(Tarjeta tarjeta)
        {
            return Tarjetas.Find(x => x.JugadorAfectado.Equipo.Nombre == tarjeta.JugadorAfectado.Equipo.Nombre &&
                                                        x.JugadorAfectado.Numero == tarjeta.JugadorAfectado.Numero &
                                                        tarjeta.Color == ColorTarjeta.Amarilla);
        }

        public List<string> ObtenerListadoIncidencias()
        {
            List<string> listadoDescripcionesIncidencias = new List<string>();
            List<Incidencia> incidencias = new List<Incidencia>();

            //Polimorfismo (por abstraccion)
            incidencias.AddRange(Goles);
            incidencias.AddRange(Tarjetas);
            incidencias.AddRange(Cambios);

            incidencias = incidencias.OrderBy(x => x.MinutoDeJuego).ToList(); //expresiones lambda de ordenamiento

            foreach (Incidencia incidencia in incidencias)
            {
                listadoDescripcionesIncidencias.Add(incidencia.ObtenerDescripcionIncidencia());
            }

            return listadoDescripcionesIncidencias;
        }

        public ResumenPartido ObtenerResultadoFinal()
        {
            ResumenPartido resumenPartido = new ResumenPartido();
            resumenPartido.EquipoLocal = this.EquipoLocal;
            resumenPartido.EquipoVisitante = this.EquipoVisitante;
            resumenPartido.GolesLocal = this.Goles.Count(x => !x.EsArcoLocal);
            resumenPartido.GolesVisitante = this.Goles.Count(x => x.EsArcoLocal);

            return resumenPartido;
        }

        public short RetornarMinutoJuego()
        {
            short minutoJuego = 0;
            foreach (Cambio cambio in Cambios)
            {
                if (cambio.MinutoDeJuego > minutoJuego)
                {
                    minutoJuego = cambio.MinutoDeJuego;
                }
            }
            foreach (Tarjeta tarjeta in Tarjetas)
            {
                if (tarjeta.MinutoDeJuego > minutoJuego)
                {
                    minutoJuego = tarjeta.MinutoDeJuego;
                }
            }
            foreach (Gol gol in Goles)
            {
                if (gol.MinutoDeJuego > minutoJuego)
                {
                    minutoJuego = gol.MinutoDeJuego;
                }
            }
            return minutoJuego;
        }
    }
}
