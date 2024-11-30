using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Order.Domain.Models;

namespace OrderRabbitMQ.Order.Domain.Interfaces
{
    public interface IOrderPlacedRepository
    {

        IEnumerable<OrderInfo> GetOrders();

        void Add(OrderInfo orderInfo);


    }
}
