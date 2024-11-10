using System;
using System.Data;
using System.Data.SqlClient;

namespace ConexionesBD
{
    public class ConexionSQLServer
    {

        private string _base;
        private string _servidor;
        private string _usuario;
        private string _clave;
        private bool _seguridad;
        private static ConexionSQLServer? _conexion = null;

        private ConexionSQLServer()
        {
            this._base = "contactos";
            this._servidor = "TROYA";
            this._usuario = "sa";
            this._clave = "SQLS3rV3r.";
            this._seguridad = false;
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection? cadenaConexion = new SqlConnection();
            try
            {
                cadenaConexion.ConnectionString = "Server=" + this._servidor + ";Database=" + this._base + ";";
                if (this._seguridad)
                {
                    cadenaConexion.ConnectionString = cadenaConexion.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadenaConexion.ConnectionString = cadenaConexion.ConnectionString + "User Id=" + this._usuario + ";Password=" + this._clave;
                }
            }
            catch (Exception)
            {
                cadenaConexion = null;
                throw;
            }
            return cadenaConexion;
        }

        public static ConexionSQLServer GetInstancia()
        {
            _conexion ??= new ConexionSQLServer();
            return _conexion ;
        }

    }
}
