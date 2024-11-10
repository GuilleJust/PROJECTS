using System.Collections.Generic;
using Datos;
using System;
using System.Data;
using System.Data.OleDb;

namespace Negocio
{
    /// <summary>
    /// Esta clase nos generará las reglas de negocio y la gestión de una Agenda Personal, dónde uno de los elementos son los teléfonos de los contactos.
    /// </summary>


    public class Agenda
    {
        private List<Contacto> contactos;

        public Agenda ()
        {
            contactos = new List<Contacto>();
        }
        /// <summary>
        /// Tendrá una regla de negocio que no nos permitirá tener más de 3 telefonos en la agenda.
        /// </summary>
        /// <param name="pTelefono"></param>
        /// <param name="pNombre"></param>
        public void InsertarAgenda(string pNombre, string pTelefono)
        {
            // Implementación de la regla de negocio.
            if (contactos.Count > 3)
            {
                throw new ArgumentException("ERR-0004:No se pueden almacenar más de 3 contactos.");
            }
            else
            {
                contactos.Add(new Contacto(pNombre, pTelefono));
            }
        }

        public DataTable Listado()
        {
            var ADO = new ContactoADO();

            return ADO.Listado2();
        }

        public DataTable Listar2()
        {
            var ADO = new ContactoADO();

            return ADO.ListadoDataReader();
        }
    }
}
