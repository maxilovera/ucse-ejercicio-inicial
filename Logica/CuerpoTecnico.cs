using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CuerpoTecnico : Persona
    {
        public bool EsTecnicoPrincipal { get; set; }
        // Segundo nulleable, cuando el bool de tecnico principal sea true, NumeroAyudanteCampo deberia permanecer en null
        public Nullable<byte> NumeroAyudanteCampo 
        {
            get
            {
                if (this.EsTecnicoPrincipal == true)
                {
                    return null;
                }
                else
                {
                    return NumeroAyudanteCampo;
                }
            }
            set
            {
                if (EsTecnicoPrincipal == true)
                {
                    this.NumeroAyudanteCampo = value;
                }
            } 
        
        }
    }
}
