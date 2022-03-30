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
        public Nullable<int> Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;
            }
        }
        private int AñoNacimiento { get; set; }
        public DateTime FechaNacimiento
        {
            get;set;
            //set
            //{
            //    //AñoNacimiento = value.Year;
            //}
            //get
            //{
            //    //return FechaNacimiento;
            //}
        }
        public string Nacionalidad { get; private set; }

        public void CalcularNacionalidad(string tipo)
        {
            if (tipo == "AR")
                Nacionalidad = "Argentina";

            Nacionalidad = "Extranjero";
        }

        //Punto 4
        public string ObtenerNombreYNacionalidad()
        {
            return $"{Nombre} - {Nacionalidad}";
        }

        //Punto 5
        public virtual bool ProximaARetiro()
        {
            if (Edad.HasValue)
            {
                return false;
            }
            else
            {
                throw new Exception("Edad es null");
            }
        }
    }
}
