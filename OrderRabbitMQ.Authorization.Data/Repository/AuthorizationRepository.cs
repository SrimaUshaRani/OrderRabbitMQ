using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Order.Data.Context;
using OrderRabbitMQ.Order.Domain.Interfaces;
using OrderRabbitMQ.Order.Domain.Models;


namespace OrderRabbitMQ.Order.Data.Repository
{
    public class AuthorizationRepository : IAuthorizationRepository
    {
        private OrderDbContext _dbContext;
        public AuthorizationRepository(OrderDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users;
        }
    }
}
