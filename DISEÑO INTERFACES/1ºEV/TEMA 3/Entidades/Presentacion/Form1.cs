using ConexionesBD;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Data.Sqlite;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void MySQL_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
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
        private void MySQLLite_Click(object sender, EventArgs e)
        {
            SqliteDataReader readerResultado;
            DataTable dt = new DataTable();
            SqliteConnection mySqlCon = new SqliteConnection();

            try
            {
                mySqlCon = ConexionSqlite.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Select * from contactos", mySqlCon);

                mySqlCon.Open();
                readerResultado = comando.BeginExecuteReader();
                dt.Load(readerResultado);
                dataGridView1.DataSource = dt;
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

        private void MySQLServer_Click(object sender, EventArgs e)
        {

        }

        private void Adapter_Click(object sender, EventArgs e)
        {

        }
    }
}