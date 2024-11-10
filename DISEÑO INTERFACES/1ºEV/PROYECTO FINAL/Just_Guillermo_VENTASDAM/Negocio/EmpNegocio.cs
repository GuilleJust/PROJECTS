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
    public class EmpNegocio
    {
        public static bool ComprobarLogin(Employee e)
        {
            return GestionBD.CheckLogin(e);
        }

        public static DataTable ListadoGenerico()
        {
            return GestionBD.ListadoEmployees();
        }

        public static DataTable ListadoPedidos()
        {
            return GestionBD.ListadoPedid();
        }

        public static DataTable ListaFiltrada(string bus)
        {
            return GestionBD.ListaFiltro(bus);
        }

        public static DataTable ListaFiltradaProductos(string bus)
        {
            return GestionBD.ListaFiltroProductos(bus);
        }

        public static DataTable ListadoProductos()
        {
            return GestionBD.ListadoProducts();
        }

        public static int EditarProducto(Product p)
        {
            return GestionBD.EditarProduct(p);
        }

        public static int InsertarEmp(Employee e)
        {
            return GestionBD.InsertarEmpleado(e);
        }

        public static int NuevoPedido(Order o)
        {
            return GestionBD.InsertarPedido(o);
        }

        public static int EditarEmp(Employee e)
        {
            return GestionBD.EditarEmpleado(e);
        }

        public static int BorrarEmp(int ID)
        {
            return GestionBD.BorrarEmpleado(ID);
        }
    }
}
