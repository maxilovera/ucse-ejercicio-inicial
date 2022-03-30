using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Jugador : Persona
    {
        public int Numero 
        {
            get;
            set; 
        }
        public bool EsTitular
        {
            get { return this.EsTitular; }
            set
            {
                if (this.Numero >= 1 && this.Numero <= 11)
                {
                    this.EsTitular = true;
                }
                else
                {
                    this.EsTitular = false;
                }
            } }
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }
        public override bool ProximaARetiro()
        {
            int? valor = null;
            try
            {
                valor = Edad;
            }
            catch (Exception e)
            {
                valor = null;
            }
            finally
            {
                if (valor == null)
                {
                    throw new Exception("No se seteo la edad de la persona");
                }
            }
            return Edad >= (Constantes.EdadRetiro - 2) 
                || Edad <= (Constantes.EdadRetiro + 2);
        }
    }
}
