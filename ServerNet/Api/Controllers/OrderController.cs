using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.Models;
using Domain.CommandHandlers;
using Domain.Commands;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly CommandHandler _commandHandler;

        public OrderController(IOrderRepository orderRepository,
            CommandHandler commandHandler)
        {
            _orderRepository = orderRepository;
            _commandHandler = commandHandler;
        }

        [HttpGet]
        public ObjectResult Get()
        {
            var result = _orderRepository.Get();
            return new ObjectResult(result);
        }

        [HttpPut]
        public void Put([FromBody] Order order)
        {
            _orderRepository.Set(order);
        }

        [HttpPost]
        public void Post()
        {
            _commandHandler.Execute(new StartDataCommand());
        }

    }
}