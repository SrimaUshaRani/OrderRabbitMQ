using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Domain.Core.Events;

namespace OrderRabbitMQ.Order.Domain.Events
{
    public class UserLoginEvent: Event
    {
        
        public string Name { get; set; }
        public string Password { get; set; }

        public UserLoginEvent(string name, string password)
        {
            Name = name;
            Password = password;
        }
    
    }
}
