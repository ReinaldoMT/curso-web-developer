using Api.Models;
using Api.Repositories;
using Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/Customer
        [HttpGet]
        public ObjectResult Get()
        {
            var customers = _customerRepository.Get();
            return new ObjectResult(customers);
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public ObjectResult Get(Guid id)
        {
            return new ObjectResult(_customerRepository.GetById(id));
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] CustomerViewModel viewModel)
        {
            if (viewModel.Id == null)
                _customerRepository.Add(new Customer {
                    Id = Guid.NewGuid(),
                    Name = viewModel.Name,
                    IsActive = viewModel.IsActive
                });
            else
                _customerRepository.Update(viewModel.Id.Value, new Customer
                {
                    Id = viewModel.Id.Value,
                    Name = viewModel.Name,
                    IsActive = viewModel.IsActive
                });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _customerRepository.Delete(id);
        }
    }
}
