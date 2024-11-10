using System.Collections.Generic;

namespace ListaRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l = new List<string>
            {
                "Perro",
                "Leon",
            };

            l.Add("Gato");
            l.Add("Pajaro");

            l.Sort();

            foreach (var la in l)
            {
                Console.WriteLine(la);
            }

            List<Mono> monos = new List<Mono>
            {
                new("Corona Negra", "Selva Negra"),
                new("Mico", "Amazonia"),
                new("Titi", "Africa"),

            };

            monos.Add(new("Enano", "Amazonia"));
            monos.Sort();
            Console.WriteLine("====MONOS====");

            foreach (var mono in monos)
            {
                Console.WriteLine(mono);
            }

            monos.Sort(new Mono.MonoComparer(Mono.CompareType.Zona));

            Console.WriteLine("====MONOS====ORDENADOS POR ZONA====");

            foreach (var mono in monos)
            {
                Console.WriteLine(mono);
            }
        }

        public class Mono:IComparable<Mono>
        {
            public string Genero { get; set; }
            public string Zona { get; set; }

            public Mono(string genero, string zona)
            {
                this.Genero = genero;
                this.Zona = zona;
            }

            public override string ToString() => $"{this.Genero}({this.Zona})";

            public int CompareTo(Mono? otroMono)
            {
                if(otroMono == null) return -1;

                int result = string.Compare(this.Genero, otroMono.Genero);

                if(result == 0)
                {
                    result = string.Compare(this.Zona, otroMono.Zona);
                }

                return result;
            }

            public enum CompareType { Genero, Zona}

            public class MonoComparer : IComparer<Mono>
            {
                public CompareType compareType;
                
                public MonoComparer(CompareType compareType)
                {
                    this.compareType = compareType;
                }

                public int Compare(Mono? x, Mono? y)
                {
                    if (x == null && y == null) return 0;
                    if (x == null) return 1;
                    if (y == null) return -1;

                    switch (this.compareType)
                    {
                        case CompareType.Genero:
                            return string.Compare(x.Genero, y.Genero);
                        case CompareType.Zona:
                            return string.Compare(x.Zona, y.Zona);
                        default:throw new Exception("Comparacion no valida");
                    }
                }
            }

        }
    }
}