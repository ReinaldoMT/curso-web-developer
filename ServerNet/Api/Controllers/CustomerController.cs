using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public ObjectResult Get()
        {
            var result = _customerRepository.Get();
            return new ObjectResult(result);
        }

        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _customerRepository.Set(customer);
            Teste(customer);
        }

        private void Teste (IBaseEntity entity)
        {
            if (entity is Customer)
            {
                var customer = entity as Customer;
            }
        }
    }
}