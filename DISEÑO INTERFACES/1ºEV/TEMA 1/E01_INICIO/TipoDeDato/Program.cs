using System;

namespace TipoDeDato
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asignacion NULL variable tipo Valor
            int? edad = null;
            System.Nullable<int> edad2 = null;

            //Tipo de datos Referencia
            var persona = new Persona() { Nombre = "Pepe" };
            CambiarNombre(persona);
            Console.WriteLine(persona.Nombre);

            //Tipo de datos Valor
            int n = 2;
            CambiarEntero(n);
            Console.WriteLine(n);

            var edadEstudiante = 10;
            dynamic mayoriaedad = null;
            
        }

        static void CambiarNombre(Persona persona)
        {
            persona.Nombre = "Paco";
        }

        static void CambiarEntero(int n)
        {
            n = 3;
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
    }
}
