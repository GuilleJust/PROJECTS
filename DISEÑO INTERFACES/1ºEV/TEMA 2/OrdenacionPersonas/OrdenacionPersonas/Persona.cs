using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacionPersonas
{
    internal class Persona:IComparable<Persona>
    {
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string apellido, int edad)
        {
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido no puede estar vacio");

            if (edad > 100 || edad < 1)
                this.Edad = -1;
            else
                this.Edad = edad;

            this.Nombre = nombre;
            this.Apellido = apellido;   
        }

        public override string ToString() => $"" + Nombre + " -- " + Apellido + " -- " + Edad;

        public int CompareTo(Persona? otrap)
        {
            if (otrap == null) return -1;
            int result = string.Compare(this.Nombre, otrap.Nombre);
            
            if(result == 0)
            {
                result = string.Compare(this.Apellido, otrap.Apellido);
            }

            return result;
        }

        

        public enum CompareType { Nombre, Apellido, Edad }

        public class PersonaComparer : IComparer<Persona>
        {
            public CompareType compareType;

            public PersonaComparer(CompareType compareType)
            {
                this.compareType = compareType;
            }

            public int Compare(Persona? x, Persona? y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return 1;
                if (y == null) return -1;

                switch (this.compareType)
                {
                    case CompareType.Nombre:
                        return string.Compare(x.Nombre, y.Nombre);
                    case CompareType.Apellido:
                        return string.Compare(x.Apellido, y.Apellido);
                    case CompareType.Edad:

                        if (x.Edad > y.Edad)
                        {
                            return 1;
                        }

                        else if (x.Edad < y.Edad)
                        {
                            return -1;
                        }

                        else
                        {
                            return 0;
                        }

                    default:
                        throw new Exception("Vaya, no esperaba esta comprobacion");
                }
            }

        }
        public static Persona operator +(Persona izquierda, Persona derecha)
        {
            Persona resultado = null;
            try
            {
                resultado = new Persona(
               izquierda.Nombre + " " + derecha.Nombre,
               izquierda.Apellido + " " + derecha.Apellido,
               izquierda.Edad + derecha.Edad);
            }
            catch
            {
                throw new Exception("Algún parámetro tiene valores NULOS");
            }

            return resultado;
        }
    }
}
