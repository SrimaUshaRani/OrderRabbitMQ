using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Order.Domain.Models;

namespace OrderRabbitMQ.Order.Domain.Interfaces
{
    public interface IAuthorizationRepository
    {
        IEnumerable<User> GetUsers();
    }
}
