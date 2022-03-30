using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CuerpoTecnico : Persona
    {
        public bool EsTecnicoPrincipal {
            get
            {
                return EsTecnicoPrincipal;
            }
            set
            {
                if (NumeroAyudanteCampo != null)
                    EsTecnicoPrincipal = false;
                else
                    EsTecnicoPrincipal = true;
            }
                }
        public int? NumeroAyudanteCampo { get; set; }
    }
}
