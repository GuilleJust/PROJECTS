using ConexionesBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class GestionBD
    {
        //LISTADO CON MYSQL
        public DataTable ListadoMySQL()
        {
            MySqlDataReader readerResultado;
            DataTable dt = new DataTable();
            MySqlConnection mySqlCon = new MySqlConnection();

            try
            {
                mySqlCon = ConexionMySQL.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Select * from contactos", mySqlCon);

                mySqlCon.Open();
                readerResultado = comando.ExecuteReader();
                dt.Load(readerResultado);
                
            }

            catch
            {
                throw new Exception("Error");
            }

            finally
            {
                if (mySqlCon.State == ConnectionState.Open)
                    mySqlCon.Close();
            }

            return dt;
        }

        //LISTADO CON SQLITE
        public DataTable ListadoSQLite()
        {
            SQLiteDataReader readerResultado;
            DataTable dt = new DataTable();
            SQLiteConnection SQLiteCon = new SQLiteConnection();

            try
            {
                SQLiteCon = ConexionSQLite.GetInstancia().CrearConexion();
                SQLiteCommand comando = new SQLiteCommand("Select * from contactos", SQLiteCon);

                SQLiteCon.Open();
                readerResultado = comando.ExecuteReader();
                dt.Load(readerResultado);

            }

            catch
            {
                throw new Exception("Error");
            }

            finally
            {
                if (SQLiteCon.State == ConnectionState.Open)
                    SQLiteCon.Close();
            }

            return dt;
        }

        //LISTADO CON SQLSERVER
        public DataTable ListadoSQLServer()
        {
            SqlDataReader readerResultado;
            DataTable dt = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionSQLServer.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Select * from contactos", SqlCon);

                SqlCon.Open();
                readerResultado = comando.ExecuteReader();
                dt.Load(readerResultado);

            }

            catch
            {
                throw new Exception("Error");
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

            return dt;
        }

        // LISTADO ADAPTER CON MYSQL
        public DataTable ListadoAdapter()
        {
            MySqlConnection mySqlCon = new MySqlConnection();
            mySqlCon = ConexionMySQL.GetInstancia().CrearConexion();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from contactos", mySqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //HECHO CON MYSQL
        public static int GuardarMySQL(ContactoEntidad c)
        {
            int filas = 0;
            MySqlConnection mySqlCon = new MySqlConnection();

            try
            {
                mySqlCon = ConexionMySQL.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand($@"INSERT INTO contactos SET
                Nombre =  '{c.Nombre}', Apellidos = '{c.Apellidos}', Telefono = '{c.Telefono}'
                ", mySqlCon);

                mySqlCon.Open();
                filas = comando.ExecuteNonQuery();

                return filas;
            }

            catch
            {
                throw new Exception("Error");
            }

            finally
            {
                if (mySqlCon.State == ConnectionState.Open)
                    mySqlCon.Close();
            }
        }

        //HECHO CON MYSQL
        public static int EditarMySQL(ContactoEntidad c)
        {
            int filas = 0;
            MySqlConnection mySqlCon = new MySqlConnection();

            try
            {
                mySqlCon = ConexionMySQL.GetInstancia().CrearConexion();

                //HAGO EL UPDATE SOBRE EL TELEFONO PORQUE SI LO HAGO SOBRE EL ID NO SE ME ACTUALIZA(NO HE ENCONTRADO SOLUCION)
                MySqlCommand comando = new MySqlCommand($@"UPDATE contactos SET Nombre =  '{c.Nombre}', 
                Apellidos = '{c.Apellidos}' 
                WHERE Telefono = '{c.Telefono}'", mySqlCon);

                mySqlCon.Open();
                filas = comando.ExecuteNonQuery();

                return filas;
            }

            catch
            {
                throw new Exception("Error");
            }

            finally
            {
                if (mySqlCon.State == ConnectionState.Open)
                    mySqlCon.Close();
            }
        }

        //HECHO CON MYSQL
        public static int BorrarMySQL(string ID)
        {
            int filas = 0;
            MySqlConnection mySqlCon = new MySqlConnection();

            try
            {
                mySqlCon = ConexionMySQL.GetInstancia().CrearConexion();
                mySqlCon.Open();
                MySqlCommand comando = new MySqlCommand( $@"DELETE FROM contactos 
                WHERE Id = '{ID}'", mySqlCon);

                filas = comando.ExecuteNonQuery();

                return filas;
            }

            catch
            {
                throw new Exception("Error");
            }

            finally
            {
                if (mySqlCon.State == ConnectionState.Open)
                    mySqlCon.Close();
            }
        }

        //HECHO CON MYSQL
        public static int CompararMySQL(ContactoEntidad c)
        {
            int filas = 0;
            MySqlConnection mySqlCon = new MySqlConnection();

            try
            {
                mySqlCon = ConexionMySQL.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand($@"Select COUNT(*) FROM contactos 
                    where Telefono = '{c.Telefono}'", mySqlCon);

                mySqlCon.Open();
                object resultado = comando.ExecuteScalar();
                
                if(resultado != null)
                {
                    filas = Convert.ToInt32(resultado);
                }
            }

            catch
            {
                throw new Exception("Error");
            }

            finally
            {
                if (mySqlCon.State == ConnectionState.Open)
                    mySqlCon.Close();
            }

            return filas;
        }
    }
}
