using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Order.Domain.Models;

namespace OrderRabbitMQ.Order.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        bool ValidateUser(User loginUser);

    }
}
