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
        public string Ciudad { get; private set; }
        public DateTime InicioPartido { get; set; }
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public List<Gol> Goles { get; set; }
        public short? TiempoDeJuego {
            get
            {
                return ObtenerListas().Last().MinutoDeJuego;
            }
                }
        public List<Cambio> Cambios { get; set; }
        public List<Tarjeta> Tarjetas { get; set; }

        public void AgregarCiudad(string ciudad)
        {
            Ciudad = ciudad;
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
            List<Incidencia> incidencias = ObtenerListas();

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

        ~Partido() 
        {
            Arbitros.Clear();
            Goles.Clear();
            Tarjetas.Clear();
            Cambios.Clear();
        }

        private List<Incidencia> ObtenerListas()
        {
            List<Incidencia> incidencias = new List<Incidencia>();
            incidencias.AddRange(Goles);
            incidencias.AddRange(Tarjetas);
            incidencias.AddRange(Cambios);

            incidencias = incidencias.OrderBy(x => x.MinutoDeJuego).ToList();

            return incidencias;
        }
        
    }
}
