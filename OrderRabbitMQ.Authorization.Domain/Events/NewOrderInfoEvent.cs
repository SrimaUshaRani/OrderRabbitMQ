using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Domain.Core.Events;

namespace OrderRabbitMQ.Order.Domain.Events
{
    public class NewOrderInfoEvent : Event
    {
        public decimal UnitPrice { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string StateorProvince { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public int OrderQty { get; set; }
        public decimal Sales { get; set; }
        public int OrderID { get; set; }

        public NewOrderInfoEvent(decimal unitPrice, int customerID, string customerName, string productName, string stateorProvince, string city, string postalCode, DateTime orderDate, DateTime shipDate, int orderQty, decimal sales, int orderID) 
        {
            UnitPrice = unitPrice;
            CustomerID = customerID;
            CustomerName = customerName;
            ProductName = productName;
            StateorProvince = stateorProvince;
            City = city;
            PostalCode = postalCode;
            OrderDate = orderDate;
            ShipDate = shipDate;
            OrderQty = orderQty;
            Sales = sales;
            OrderID = orderID;

        }
    }
}
