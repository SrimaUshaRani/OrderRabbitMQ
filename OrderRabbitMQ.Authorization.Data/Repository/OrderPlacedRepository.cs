using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Order.Data.Context;
using OrderRabbitMQ.Order.Domain.Interfaces;
using OrderRabbitMQ.Order.Domain.Models;

namespace OrderRabbitMQ.Order.Data.Repository
{
    public class OrderPlacedRepository : IOrderPlacedRepository
    {
        private OrderDbContext _dbContext;

        public OrderPlacedRepository(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(OrderInfo orderInfo)
        {
            _dbContext.Add<OrderInfo>(orderInfo);
            _dbContext.SaveChanges();
        }

        public IEnumerable<OrderInfo> GetOrders()
        {
            return _dbContext.Orders;
        }



    }
}
