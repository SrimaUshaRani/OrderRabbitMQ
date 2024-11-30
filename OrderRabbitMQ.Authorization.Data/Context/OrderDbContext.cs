using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OrderRabbitMQ.Order.Domain.Models;

namespace OrderRabbitMQ.Order.Data.Context
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users{ get; set; }

        public DbSet<OrderInfo> Orders { get; set; }
    }
    
}
