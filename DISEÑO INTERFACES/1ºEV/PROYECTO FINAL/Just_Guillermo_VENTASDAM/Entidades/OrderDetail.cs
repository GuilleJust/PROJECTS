using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductID { get; set; }
        public double UnityPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        public OrderDetail(int orderId, int productID, double unityPrice, int quantity, int discount)
        {
            if (double.IsNaN(unityPrice))
                throw new ArgumentException("Unity price can not be null");
            if (quantity == null)
                throw new ArgumentException("Quantity can not be null");
            if (discount == null)
                throw new ArgumentException("Discount can not be null");

            OrderId = orderId;
            ProductID = productID;
            UnityPrice = unityPrice;
            Quantity = quantity;
            Discount = discount;
        }

        public OrderDetail()
        {
            OrderId = 0;
            ProductID = 0;
            UnityPrice = 0;
            Quantity = 0;
            Discount = 0;
        }
    }
}
