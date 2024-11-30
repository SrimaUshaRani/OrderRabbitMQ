using System;
using System.Collections.Generic;
using System.Text;

namespace OrderRabbitMQ.Order.Domain.Command
{
    public class PlaceNewOrderCommand : PlaceOrderCommand
    {
        public PlaceNewOrderCommand(decimal unitPrice, int customerID, string customerName, string productName, string stateorProvince, string city, string postalCode, DateTime orderDate, DateTime shipDate, int orderQty, decimal sales, int orderID)
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
