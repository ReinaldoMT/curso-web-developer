using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces;
using Domain.Models;

namespace Infra.LocalData.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository()
        {

        }
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            return new List<Customer> { new Customer { Name = "LocalData" } };
        }

        public Customer GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Set(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
