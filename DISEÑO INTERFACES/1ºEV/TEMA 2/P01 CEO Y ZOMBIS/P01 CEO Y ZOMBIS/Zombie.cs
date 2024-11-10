using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_CEO_Y_ZOMBIS
{
    internal class Zombie:CEO
    {
        new public string? Nombre { get; set; } = "Zombie";
        new public int Edad { get; set; } = 0;
        public Zombie(CEO ceo)
        {
            base.Nombre = ceo.Nombre;
            base.Edad = ceo.Edad;
            base.Bienestar = ceo.Bienestar;
            base.SoyZombi = true;

            Debug.WriteLine(Exorcismo());
        }

        public new CEO? AddBienestar()
        {
            this.Bienestar += 5;

            if(this.Bienestar < 0)
                return (CEO)this;
            
            return null;
        }

        public string Exorcismo() => $"Yo era " + base.Nombre + ", tenia " + base.Edad + " años y vivia sin bienestar";

        public override string ToString() => $"Soy un Zombie!!!!";
    }
}
