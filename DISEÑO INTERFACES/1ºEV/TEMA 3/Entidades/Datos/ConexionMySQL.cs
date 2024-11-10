using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ConexionesBD
{
    public class ConexionMySQL
    {
        private string _base;
        private string _servidor;
        private string _usuario;
        private string _clave;
        private static ConexionMySQL? _conexion = null;

        private ConexionMySQL()
        {
            this._base = "contactos";
            this._servidor = "localhost";
            this._usuario = "root";
            this._clave = "";
        }
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this._servidor + ";Database=" + this._base + ";Uid=" + this._usuario + ";Pwd=" + this._clave;
            }
            catch (Exception)
            {
                Cadena = null;
                throw;
            }
            return Cadena;
        }

        public static ConexionMySQL GetInstancia()
        {
            /*if (_conexion == null)
            {
                _conexion = new ConexionMySQL();
            }*/
            _conexion ??= new ConexionMySQL();
            return _conexion ;
        }

    }
}
