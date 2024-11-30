using System;
using System.Collections.Generic;
using System.Text;

namespace OrderRabbitMQ.Order.Application.Models
{
    public class NewOrder
    {
        public decimal UnitPrice { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string StateorProvince { get; set; } = "";
        public string City { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public int OrderQty { get; set; }
        public decimal Sales { get; set; }
        public int OrderID { get; set; }

    }
}
