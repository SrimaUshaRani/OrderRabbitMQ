using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderRabbitMQ.Domain.Core.Bus;
using OrderRabbitMQ.Domain.Core.Events;
using OrderRabbitMQ.Order.Domain.Events;
using OrderRabbitMQ.Order.Domain.Interfaces;
using OrderRabbitMQ.Order.Domain.Models;

namespace OrderRabbitMQ.Order.Domain.EventHandlers
{
    public class NewOrderInfoEventHandler: IEventHandler<NewOrderInfoEvent>
    {
        private readonly IOrderPlacedRepository _orderPlacedRepository;
        public NewOrderInfoEventHandler(IOrderPlacedRepository orderPlacedRepository)
        {
                _orderPlacedRepository = orderPlacedRepository;
        }


        public Task Handle(NewOrderInfoEvent @event)
        {
            _orderPlacedRepository.Add(new OrderInfo()
            {
                UnitPrice = @event.UnitPrice,
                CustomerID = @event.CustomerID,
                CustomerName = @event.CustomerName,
                ProductName = @event.ProductName,
                StateorProvince = @event.StateorProvince,
                City = @event.City,
                PostalCode = @event.PostalCode,
                OrderDate = @event.OrderDate,
                ShipDate = @event.ShipDate,
                OrderQty = @event.OrderQty,
                Sales = @event.Sales,
                OrderID = @event.OrderID

            });
            return Task.CompletedTask;
        }
    }
}
