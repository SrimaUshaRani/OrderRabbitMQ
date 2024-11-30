using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderRabbitMQ.Order.Domain.Interfaces;
//using OrderRabbitMQ.Order.Application.Interfaces;
//using MicroRabbit.Banking.Application.Models;
//using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using OrderRabbitMQ.Order.Domain.Models;
using OrderRabbitMQ.Order.Domain.Events;
using OrderRabbitMQ.Order.Application.Models;
using OrderRabbitMQ.Order.Application.Interfaces;
using OrderRabbitMQ.Order.Application.Servises;

namespace OrderRabbitMQ.Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
             _orderService = orderService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<OrderInfo>> Get()
        {
            return Ok(_orderService.GetOrders());
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewOrder newOrder)
        {
            _orderService.NewOrderPublish(newOrder);
            return Ok(newOrder);
        }
    }
}
