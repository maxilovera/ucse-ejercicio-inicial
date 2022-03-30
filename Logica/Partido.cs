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
        public short TiempoDeJuego { get { return Convert.ToInt16(AgregarYOrdenarIncidencias()[0].MinutoDeJuego); } }
        public List<Cambio> Cambios { get; set; }
        public List<Tarjeta> Tarjetas { get; set; }

        ~Partido() //destructor
        {
            Goles.Clear();
            Cambios.Clear();
            Tarjetas.Clear();
            Arbitros.Clear();   

        }

        public void setearCiudad(string pCiudad )
        {
            Ciudad = pCiudad;
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
                                                        x.JugadorAfectado.NumeroDeCamiseta == tarjeta.JugadorAfectado.NumeroDeCamiseta &
                                                        tarjeta.Color == ColorTarjeta.Amarilla);
        }
        private List<Incidencia> AgregarYOrdenarIncidencias()
        {
            List<Incidencia> incidencias = new List<Incidencia>();

            //Polimorfismo (por abstraccion)
            incidencias.AddRange(Goles);
            incidencias.AddRange(Tarjetas);
            incidencias.AddRange(Cambios);

            incidencias = incidencias.OrderBy(x => x.MinutoDeJuego).ToList();
            return incidencias;
        }
        public List<string> ObtenerListadoIncidencias()
        {
            List<string> listadoDescripcionesIncidencias = new List<string>();
             //expresiones lambda de ordenamiento

            foreach (Incidencia incidencia in AgregarYOrdenarIncidencias())
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
    }
}
