﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderRabbitMQ.Domain.Core.Commands;
using OrderRabbitMQ.Domain.Core.Events;

namespace OrderRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;


        void Subscribe<T, TH>()
            where T:Event
            where TH : IEventHandler<T>;
    
    }

}
