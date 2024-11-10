using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entidades;

namespace Datos
{
    public class GestionBD
    {
        public static DataTable ListadoEmployees()
        {
            SqlDataReader readerResultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConexion = new SqlConnection();
            try
            {
                sqlConexion.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;


                SqlCommand comando = new SqlCommand("Select * from employees", sqlConexion);
                comando.CommandType = CommandType.Text;
                sqlConexion.Open();
                readerResultado = comando.ExecuteReader();
                Tabla.Load(readerResultado);
                return Tabla;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        public static DataTable ListaFiltro(string txt)
        {
            SqlDataReader readerResultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConexion = new SqlConnection();
            try
            {
                sqlConexion.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;


                SqlCommand comando = new SqlCommand($@"Select * from employees where EmployeeID like '%{txt}%' or FirstName like '%{txt}%' or LastName like '%{txt}%'", sqlConexion);
                comando.CommandType = CommandType.Text;
                sqlConexion.Open();
                readerResultado = comando.ExecuteReader();
                Tabla.Load(readerResultado);
                return Tabla;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        public static DataTable ListaFiltroProductos(string txt)
        {
            SqlDataReader readerResultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConexion = new SqlConnection();
            
            try
            {
                sqlConexion.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;
                SqlCommand comando = new SqlCommand($@"Select * from Products where ProductID like '%{txt}%' or ProductName like '%{txt}%'", sqlConexion);
                comando.CommandType = CommandType.Text;
                sqlConexion.Open();
                readerResultado = comando.ExecuteReader();
                Tabla.Load(readerResultado);
                return Tabla;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        public static DataTable ListadoProducts()
        {
            SqlDataReader readerResultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConexion = new SqlConnection();
            try
            {
                sqlConexion.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;


                SqlCommand comando = new SqlCommand("Select * from products", sqlConexion);
                comando.CommandType = CommandType.Text;
                sqlConexion.Open();
                readerResultado = comando.ExecuteReader();
                Tabla.Load(readerResultado);
                return Tabla;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        public static DataTable ListadoPedid()
        {
            SqlDataReader readerResultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConexion = new SqlConnection();
            try
            {
                sqlConexion.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;


                SqlCommand comando = new SqlCommand("Select * from Orders", sqlConexion);
                comando.CommandType = CommandType.Text;
                sqlConexion.Open();
                readerResultado = comando.ExecuteReader();
                Tabla.Load(readerResultado);
                return Tabla;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        public static bool CheckLogin(Employee e)
        {
            SqlConnection sqlConexion = new SqlConnection();
            try
            {
                sqlConexion.ConnectionString =
                    ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;

                SqlCommand comando = new SqlCommand(@$"Select * from Employees
                    WHERE Login like '{e.Login}'
                    AND Password like '{e.Password}'", sqlConexion);
                comando.CommandType = CommandType.Text;
                sqlConexion.Open();
                var fila = comando.ExecuteReader();
                bool loginOK = false;
                while (fila.Read())
                {
                    //e.EmployeeID = Convert.ToInt32(fila["EmployeeID"]);
                    e.Login = Convert.ToString(fila["Login"]);
                    e.Password = Convert.ToString(fila["Password"]);
                    //e.LastName = Convert.ToString(fila["LastName"]);
                    //e.FirstName = Convert.ToString(fila["FirstName"]);
                    //e.Title = Convert.ToString(fila["Title"]);
                    //e.TitleOfCourtesy = Convert.ToString(fila["TitleOfCourtesy"]);
                    //e.ReportsTo = Convert.ToInt32(fila["ReportsTo"]);

                    /*
                    if (fila["imagen"] != DBNull.Value)
                    {
                        e.Photo = (byte[])fila["imagen"];
                    }*/

                    loginOK = true;
                }

                return loginOK;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }
    
        public static int InsertarEmpleado(Employee e)
        {
            int filas = 0;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;

                SqlCommand comando = new SqlCommand($@"Insert into Employees values ('{e.Login}', '{e.Password}', '{e.LastName}', '{e.FirstName}', '{e.Title}', '{e.TitleOfCourtesy}', '{e.BirthDate}', '{e.HireDate}', '{e.Address}', '{e.City}', '{e.Region}', '{e.PostalCode}', '{e.Country}', '{e.HomePhone}', '{e.Extension}', null, '{e.Notes}', '{e.ReportsTo}', '{e.PhotoPath}')", sqlCon);

                sqlCon.Open();
                filas = comando.ExecuteNonQuery(); 

                return filas;
            }

            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public static int EditarEmpleado(Employee e)
        {
            int filas = 0;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;

                SqlCommand comando = new SqlCommand($@"Update Employees set Login = '{e.Login}', Password = '{e.Password}', LastName = '{e.LastName}', FirstName = '{e.FirstName}', Title = '{e.Title}', TitleOfCourtesy = '{e.TitleOfCourtesy}', BirthDate = '{e.BirthDate}', HireDate = '{e.HireDate}', Address = '{e.Address}', City = '{e.City}', Region = '{e.Region}', PostalCode = '{e.PostalCode}', Country = '{e.Country}', HomePhone = '{e.HomePhone}', Extension = '{e.Extension}', Photo = null, Notes = '{e.Notes}', ReportsTo = '{e.ReportsTo}', PhotoPath = '{e.PhotoPath}' where EmployeeID = '{e.EmployeeID}'", sqlCon);

                sqlCon.Open();
                filas = comando.ExecuteNonQuery();

                return filas;
            }

            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        
        public static int BorrarEmpleado(int ID)
        {
            int filas = 0;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;

                SqlCommand comando = new SqlCommand($@" DELETE FROM Employees where EmployeeID = '{ID}'", sqlCon);

                sqlCon.Open();
                filas = comando.ExecuteNonQuery();

                return filas;
            }

            catch(Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public static int EditarProduct(Product p)
        {
            int filas = 0;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;

                SqlCommand comando = new SqlCommand(@$"UPDATE Products SET UnitPrice = @Money WHERE ProductID = {p.ProductID}", sqlCon);
                SqlParameter parameterMoney = new SqlParameter("@Money", SqlDbType.Money);
                comando.Parameters.AddWithValue("@Money", p.UnitPrice);

                sqlCon.Open();
                filas = comando.ExecuteNonQuery();

                return filas;
            }

            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public static int InsertarPedido(Order o)
        {
            int filas = 0;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerSa"].ConnectionString;

                SqlCommand comando = new SqlCommand($@"Insert into Orders values ('{o.CustomerId}', '{o.EmployeeID}' , null, '{o.RequiredDate}', '{o.ShippedDate}' , '{o.ShipVia}' , null, '{o.ShipName}' , '{o.ShipAddress}' , '{o.ShipCity}' , '{o.ShipRegion}' , '{o.ShipPostalCode}' , '{o.ShipCountry}') ", sqlCon);

                sqlCon.Open();
                filas = comando.ExecuteNonQuery();

                return filas;
            }

            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
