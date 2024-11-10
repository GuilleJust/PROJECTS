using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public Shipper(int shipperID, string companyName, string phone)
        {
            if (string.IsNullOrWhiteSpace(companyName))
                throw new ArgumentException("Company name can not be null");

            ShipperID = shipperID;
            CompanyName = companyName;
            Phone = phone;
        }

        public Shipper()
        {
            ShipperID = 0;
            CompanyName = "";
            Phone = "";
        }
    }
}
