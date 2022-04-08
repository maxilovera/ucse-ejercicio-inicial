using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get { return _instance; }
        }

        public void EscribirEnConsola(string mensaje)
        {
            System.Diagnostics.Debug.WriteLine(mensaje);
        }
    }
}
