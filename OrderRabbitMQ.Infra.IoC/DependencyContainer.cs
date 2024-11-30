using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OrderRabbitMQ.Domain.Core.Bus;
using OrderRabbitMQ.Infra.Bus;
using OrderRabbitMQ.Order.Application.Interfaces;
using OrderRabbitMQ.Order.Application.Servises;
using OrderRabbitMQ.Order.Data.Context;
using OrderRabbitMQ.Order.Data.Repository;
using OrderRabbitMQ.Order.Domain.Command;
using OrderRabbitMQ.Order.Domain.CommandHandlers;
using OrderRabbitMQ.Order.Domain.EventHandlers;
using OrderRabbitMQ.Order.Domain.Events;
using OrderRabbitMQ.Order.Domain.Interfaces;

namespace OrderRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {

            // Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);

            });

            //Subscriptions
            services.AddTransient<NewOrderInfoEventHandler>();

            // Domain Events
            services.AddTransient<IEventHandler<NewOrderInfoEvent>, NewOrderInfoEventHandler>();

            //Domain Order Commands
             services.AddTransient<IRequestHandler<PlaceNewOrderCommand, bool>, PlaceOrderCommandHandler>();

            //Application Services
            services.AddTransient<UserService, UserService>();
            services.AddTransient<IOrderService, OrderService>();

            ////Data
            services.AddTransient<IAuthorizationRepository, AuthorizationRepository>();
            services.AddTransient<IOrderPlacedRepository, OrderPlacedRepository>();
            services.AddTransient<OrderDbContext>();
          
        }
    }

}
