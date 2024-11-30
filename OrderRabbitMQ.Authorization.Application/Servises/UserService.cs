using System;
using System.Collections.Generic;
using System.Text;
using OrderRabbitMQ.Domain.Core.Bus;
using OrderRabbitMQ.Order.Application.Interfaces;
using OrderRabbitMQ.Order.Domain.Models;
using OrderRabbitMQ.Order.Domain.Interfaces;
using OrderRabbitMQ.Order.Domain.Events;
using System.Linq;

namespace OrderRabbitMQ.Order.Application.Servises
{
    public class UserService : IUserService
    {
        private readonly IAuthorizationRepository _authorizationReposit;
        
        public UserService(IAuthorizationRepository authorizationReposity) 
        {
            _authorizationReposit=authorizationReposity;
           
        }
        public IEnumerable<User> GetUsers()
        {
            return _authorizationReposit.GetUsers();
        }

        public bool ValidateUser(User loginUser)
        {
          return  _authorizationReposit.GetUsers().ToList<User>().
                Exists(p => p.Name == loginUser.Name && p.Password == loginUser.Password);
            
        }
    }
}
