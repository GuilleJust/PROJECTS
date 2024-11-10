using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Negocio
    {
        ContactoEntidad contacto = new ContactoEntidad();
        public static DataTable ListadoContactosMySQL()
        {
            GestionBD gb = new GestionBD();
            DataTable dt = new DataTable();
            dt = gb.ListadoMySQL();

            return dt;
        }

        public static DataTable ListadoContactosSQLite()
        {
            GestionBD gb = new GestionBD();
            DataTable dt = new DataTable();
            dt = gb.ListadoSQLite();

            return dt;
        }

        public static DataTable ListadoContactosSQLServer()
        {
            GestionBD gb = new GestionBD();
            DataTable dt = new DataTable();
            dt = gb.ListadoSQLServer();

            return dt;
        }

        public static DataTable ListadoContactosAdapter()
        {
            GestionBD gb = new GestionBD();
            DataTable dt = new DataTable();
            dt = gb.ListadoAdapter();

            return dt;
        }

        public static int GuardarContactoMySQL(ContactoEntidad c)
        {
            return Datos.GestionBD.GuardarMySQL(c);
        }

        public static int EditarContactoMySQL(ContactoEntidad c)
        {
            return Datos.GestionBD.EditarMySQL(c);
        }

        public static int BorrarContactoMySQL(string c)
        {
            return Datos.GestionBD.BorrarMySQL(c);
        }

        public static int CompararContactoMySQL(ContactoEntidad c)
        {
            return Datos.GestionBD.CompararMySQL(c);
        }
    }
}
