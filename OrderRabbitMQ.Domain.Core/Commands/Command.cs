﻿using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Domain.Core.Events;

namespace OrderRabbitMQ.Domain.Core.Commands
{
    public abstract class Command : Message
    {

        public DateTime Timestamp { get; protected set; }
        protected Command() 
        {
            Timestamp = DateTime.Now;    
        }
    }
}
