using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_CEO_Y_ZOMBIS
{
    internal class CEO
    {
        private int? edad;
        public string Nombre { get; set; }
        public int? Edad 
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 10 || value > 110)
                    throw new ArgumentException("Edad fuera de parametros");

                edad = value;
            }
        }
        public int Bienestar { get; set; }
        public bool SoyZombi { get; set; } = default;

        public CEO(string nombre, int edad, int bienestar=100)
        {
            if(string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Nombre no valido");
          

            this.Nombre = nombre;
            this.Edad = edad;
            this.Bienestar = bienestar;
            SoyZombi = false;
        }

        public CEO()
        {
            Nombre = "Testing CEO";
            Edad = 20;
            Bienestar = 100;
            SoyZombi = false;
        }

        public void AddBienestar()
        {
            this.Bienestar += 5;
        }

        public Zombie? AddMalestar()
        {
            this.Bienestar -= 5;

            if(this.Bienestar <= 0)
            {
                Zombie z = new Zombie(this);
                return z;
            }

            return null;
        }

        public override string ToString()
        {
            return "CEO:" + Nombre + " - [" + Edad + "] - " + "Bienestar:" + Bienestar;   
        }
    }
}
