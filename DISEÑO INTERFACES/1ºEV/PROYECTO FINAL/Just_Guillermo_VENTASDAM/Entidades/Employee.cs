using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Entidades
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public string? BirthDate { get; set; }
        public string? HireDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? HomePhone { get; set; }
        public string? Extension { get; set; }
        public string? Notes { get; set; }
        public byte[]? Photo { get; set; }
        public int? ReportsTo { get; set; }
        public string? PhotoPath { get; set; }

        public Employee(int employeeID, string login, string password, string lastName, string firstName, string title, string titleOfCourtesy, string birthDate, 
            string hireDate, string address, string city, string region, string postalCode, string country, string homePhone, string extension, 
            string notes, byte[] photo, int reportsTo, string photoPath)
        {

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name can not be null");
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name can not be null");

            EmployeeID = employeeID;
            Login = login;
            Password = password;
            LastName = lastName;
            FirstName = firstName;
            Title = title;
            TitleOfCourtesy = titleOfCourtesy;
            BirthDate = birthDate;
            HireDate = hireDate;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            HomePhone = homePhone;
            Extension = extension;
            Notes = notes;
            Photo = photo;
            ReportsTo = reportsTo;
            PhotoPath = photoPath;
        }

        public Employee()
        {
            Login = "";
            Password = "";
            LastName = "";
            FirstName = "";
            Title = "";
            TitleOfCourtesy = "";
            BirthDate = "";
            HireDate = "";
            Address = "";
            City = "";
            Region = "";
            PostalCode = "";
            Country = "";
            HomePhone = "";
            Extension = "";
            Notes = "";
            Photo = null;
            ReportsTo = 2;
            PhotoPath = "";
        }
    }
}
