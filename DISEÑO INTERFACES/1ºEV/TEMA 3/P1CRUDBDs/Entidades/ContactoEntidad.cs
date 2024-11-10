using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoEntidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }

        public ContactoEntidad()
        {
            ID = 0;
            Nombre = "";
            Apellidos = "";
            Telefono = "";
        }
    }
}
