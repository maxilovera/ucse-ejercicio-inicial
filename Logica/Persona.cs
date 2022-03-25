using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //Punto 4
        public string ObtenerNombreYNacionalidad()
        {
            return $"{Nombre} - {Nacionalidad}";
        }

        //Punto 5
        public virtual bool ProximaARetiro()
        {
            return false;
        }
    }
}
