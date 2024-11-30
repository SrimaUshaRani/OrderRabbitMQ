using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Order.Application.Models;
using OrderRabbitMQ.Order.Domain.Models;

namespace OrderRabbitMQ.Order.Application.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderInfo> GetOrders();
        void NewOrderPublish(NewOrder newOrder);

        void SaveOrder(OrderInfo orderInfo);
    }
}
