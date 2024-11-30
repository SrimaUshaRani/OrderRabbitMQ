using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Domain.Core.Bus;
using OrderRabbitMQ.Order.Application.Interfaces;
using OrderRabbitMQ.Order.Application.Models;
using OrderRabbitMQ.Order.Domain.Command;
using OrderRabbitMQ.Order.Domain.Interfaces;
using OrderRabbitMQ.Order.Domain.Models;

namespace OrderRabbitMQ.Order.Application.Servises
{
    public class OrderService : IOrderService
    {
        private readonly IOrderPlacedRepository _orderPlacedRepository;
        private readonly IEventBus _bus;

        public OrderService(IOrderPlacedRepository orderPlacedRepository, IEventBus bus)
        {
            _orderPlacedRepository = orderPlacedRepository;
            _bus = bus;

        }


        public IEnumerable<OrderInfo> GetOrders()
        {
            return _orderPlacedRepository.GetOrders();
            // throw new NotImplementedException();
        }

        public void NewOrderPublish(NewOrder newOrder)
        {
            // _orderPlacedRepository.Add(orderInfo);
            // _bus.Publish<OrderInfo>(orderInfo);

            var placeNewOrderCommand = new PlaceNewOrderCommand(
                newOrder.UnitPrice,
                newOrder.CustomerID,
                newOrder.CustomerName,
                newOrder.ProductName,
                newOrder.StateorProvince,
                newOrder.City,
                newOrder.PostalCode,
                newOrder.OrderDate,
                newOrder.ShipDate,
                newOrder.OrderQty,
                newOrder.Sales,
                newOrder.OrderID

             );

            _bus.SendCommand(placeNewOrderCommand);

        }

        public void SaveOrder(OrderInfo orderInfo)
        {
            _orderPlacedRepository.Add(orderInfo);
        }
    }
}
