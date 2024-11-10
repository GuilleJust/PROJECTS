using System.Data.SQLite;
using System;
using System.Data;

namespace ConexionesBD
{
    internal class ConexionSQLite
    {

        private string _baseDeDatos;
        private static ConexionSQLite? Con = null;
        

        private ConexionSQLite()
        {
            this._baseDeDatos = "contactos.db";           
        }
        public SQLiteConnection CrearConexion()
        {
            SQLiteConnection? Conexion = new SQLiteConnection(); ;
            try
            {
                Conexion.ConnectionString = $"Data Source=./{this._baseDeDatos};";
            }
            catch (Exception)
            {
                Conexion = null;
                throw;
            }
            return Conexion;
        }

        public static ConexionSQLite GetInstancia()
        {
            Con ??= new ConexionSQLite();
            return Con ;
        }

    }
}
