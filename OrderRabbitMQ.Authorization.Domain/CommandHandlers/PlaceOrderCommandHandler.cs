using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Domain.Core.Bus;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using OrderRabbitMQ.Order.Domain.Command;
using OrderRabbitMQ.Order.Domain.EventHandlers;
using OrderRabbitMQ.Order.Domain.Events;

namespace OrderRabbitMQ.Order.Domain.CommandHandlers
{
    public class PlaceOrderCommandHandler : IRequestHandler<PlaceNewOrderCommand, bool>
    {
        private readonly IEventBus _bus;

        public PlaceOrderCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        //public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        //{
        //    //publish event to RabbitMQ
        //    _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));

        //    return Task.FromResult(true);
        //}

        public Task<bool> Handle(PlaceNewOrderCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new NewOrderInfoEvent(
               request.UnitPrice,
                    request.CustomerID,
                    request.CustomerName,
                    request.ProductName,
                    request.StateorProvince,
                    request.City,
                    request.PostalCode,
                    request.OrderDate,
                    request.ShipDate,
                    request.OrderQty,
                    request.Sales,
                    request.OrderID
                ));

            return Task.FromResult(true);
        }
    }
}
