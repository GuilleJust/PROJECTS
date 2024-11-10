using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }  
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int RecorderLevel { get; set; }
        public int Discontinued { get; set; }

        public Product(int productID,string productName, int supplierID, int categoryID, string quantityPerUnit, decimal unitPrice, int unitsInStock, int unitsOnOrder, int recorderLevel, int discontinued)
        {
            if (string.IsNullOrWhiteSpace(productName))
                throw new ArgumentException("Product name can not be null");

            ProductID = productID;
            ProductName = productName;
            SupplierID = supplierID;
            CategoryID = categoryID;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            RecorderLevel = recorderLevel;
            Discontinued = discontinued;
        }

        public Product()
        {
            ProductID = 0;
            ProductName = "";
            SupplierID = 0;
            CategoryID = 0;
            QuantityPerUnit = "";
            UnitPrice = 0;
            UnitsInStock = 0;
            UnitsOnOrder = 0;
            RecorderLevel = 0;
            Discontinued = 0;
        }
    }
}
