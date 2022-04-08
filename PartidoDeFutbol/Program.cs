using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidoDeFutbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.EscribirEnConsola("Funciona");

            Console.ReadKey();
        }
    }
}
