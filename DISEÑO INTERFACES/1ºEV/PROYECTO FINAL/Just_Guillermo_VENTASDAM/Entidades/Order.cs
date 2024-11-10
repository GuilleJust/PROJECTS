using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeID { get; set; }
        public string OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public double Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        //public List<OrderDetail> Details { get; set; }

        public Order(int orderId, string customerId, int employeeID, string orderDate, DateTime requiredDate, DateTime shippedDate, int shipVia, double freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPostalCode, string shipCountry)
        {
            OrderId = orderId;
            CustomerId = customerId;
            EmployeeID = employeeID;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            ShipVia = shipVia;
            Freight = freight;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
            //Details = new List<OrderDetail>();
        }

        public Order()
        {
            OrderId = 0;
            CustomerId = "";
            EmployeeID = 0;
            OrderDate = "";
            RequiredDate = default;
            ShippedDate = default;
            ShipVia = 0;
            Freight = 0;
            ShipName = "";
            ShipAddress = "";
            ShipCity = "";
            ShipRegion = "";
            ShipPostalCode = "";
            ShipCountry = "";
            //Details = new List<OrderDetail>();
        }
    }
}
