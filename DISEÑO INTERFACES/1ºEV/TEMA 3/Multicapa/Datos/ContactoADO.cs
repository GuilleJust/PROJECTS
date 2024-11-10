using System;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data;

namespace Datos
{
    public class ContactoADO
    {
        private BDAccess bbdd; //Para Access

        public ContactoADO()
        {
            bbdd = new BDAccess();
        }

        public int Insertar(string SQL)
        {
            OleDbDataReader lector;

            int Id = 0;
            bbdd.Abrir();
            try
            {
                lector = bbdd.EjecutarDML(SQL);
                while (lector.Read())
                { 
                    Id = lector.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                Id = 0;
                Debug.WriteLine("Error al insertar:" + ex.Message);
            }
            finally
            {
                bbdd.Cerrar();
            }
            return Id;
        }

        public  DataTable Listado2()
        {
            OleDbDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                da = bbdd.EjecutarSelect("Select * from telefonos");
                da.Fill(dt);

                return dt;
            }

            catch
            {
                throw new Exception("Error");
            }
        }

        public DataTable ListadoDataReader()
        {
            OleDbDataReader da;
            DataTable dt = new DataTable();

            try
            {
                bbdd.Abrir();
                da = bbdd.EjecutarDML("Select * from telefonos");
                dt.Load(da);

                return dt;
            }

            catch
            {
                throw new Exception("Error");
            }

            finally
            {
                bbdd.Cerrar();
            }
        }
    }
}


