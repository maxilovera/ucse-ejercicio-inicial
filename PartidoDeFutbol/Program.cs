using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidoDeFutbol
{
    class Clima
    {
        public int? GradosCelsius { get; set; }
        public Nullable<int> GradosFarenheit { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clima clima = new Clima();

            bool tieneDato = clima.GradosFarenheit.HasValue;
            
            int valorODefecto = clima.GradosCelsius.GetValueOrDefault();

            if (tieneDato)
            { 
                int valor = clima.GradosCelsius.Value;
            }

            //
            Persona persona = new Persona();
            persona.FechaNacimiento = new DateTime(1987, 5, 14);            

            int? edad = persona.Edad;

            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            try
            {
                int division = numero1 / numero2;
                Console.WriteLine($"Resultado: {division}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un problema en la division");
            }
            finally
            {
                Console.WriteLine("Termino");
            }
            


            Console.Read();
        }
    }
}
