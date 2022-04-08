using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {
        }
        public static Singleton Instancia 
        {
            get
            {
                if (instance == null) { instance = new Singleton(); }
                return instance;
            }
        }
        public bool EscribirenConsola(string mensaje)
        {
            if (mensaje != "" && mensaje != null)
            {
                System.Diagnostics.Debug.WriteLine(mensaje);
                return true;
            }
            return false;

        }
    }
}
