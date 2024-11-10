using System.Data;
using System.Data.OleDb;
using System.Runtime.Versioning;

namespace Datos
{
    [SupportedOSPlatform("windows")]
    class BDAccess
    {
        private OleDbConnection conexionConBD;
        private OleDbCommand orden;
        private OleDbDataReader lector;
        static string strConexion;

        public BDAccess()
        {
            strConexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|{0};Persist Security Info=True;", "tfnos.accdb");
            conexionConBD = null;
            orden = null;
            lector = null;
        }

        public void Abrir()
        {
            //Abrir la base de datos
            conexionConBD = new OleDbConnection(strConexion);
            conexionConBD.Open();
        }
        public void Cerrar()
        {
            // Cerrar la conexión cuando ya no sea necesaria.
            if (lector != null)
            {
                lector.Close();
            }

            if (conexionConBD != null)
            {
                conexionConBD.Close();
            }
        }

        public OleDbDataAdapter EjecutarSelect(string SQL)
        {
            conexionConBD = new OleDbConnection(strConexion);
            orden = new OleDbCommand(SQL, conexionConBD);
            OleDbDataAdapter resultado = new OleDbDataAdapter(orden);
            return resultado;
        }

        public OleDbDataReader EjecutarDML(string SQL)
        {
            orden = new OleDbCommand(SQL, conexionConBD);
            lector = orden.ExecuteReader();
            return lector;
        }

        public int EjecutarDDL(string SQL)
        {
            int filasAfectadas = 0;
            orden = new OleDbCommand(SQL, conexionConBD);
            filasAfectadas = orden.ExecuteNonQuery();
            return filasAfectadas;
        }
    }
}
