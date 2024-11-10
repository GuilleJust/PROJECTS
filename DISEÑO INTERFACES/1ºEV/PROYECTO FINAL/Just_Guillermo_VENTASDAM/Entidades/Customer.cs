using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public Customer(int customerID, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            if (string.IsNullOrWhiteSpace(companyName))
                throw new ArgumentException("Company name can not be null");
            
            CustomerID = customerID;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Fax = fax;
        }

        public Customer()
        {
            CustomerID = 0;
            CompanyName = "";
            ContactName = "";
            ContactTitle = "";
            Address = "";
            City = "";
            Region = "";
            PostalCode = "";
            Country = "";
            Phone = "";
            Fax = "";
        }
    }
}
