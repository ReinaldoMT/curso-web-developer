using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.EFData.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(Guid id)
        {
            var customer = GetById(id);
            customer.IsDeleted = true;
            _context.Customers.Update(customer);
        }

        public IEnumerable<Customer> Get()
        {
            return _context.Customers
                .Where(x => !x.IsDeleted)
                .OrderBy(x => x.Name);
        }

        public Customer GetById(Guid id)
        {
            return _context.Customers.Find(id);
        }

        public void Set(Customer customer)
        {
            if (_context.Customers.Any(x => x.Id == customer.Id))
            {
                _context.Customers.Update(customer);
            }
            else
            {
                _context.Customers.Add(customer);
            }
        }
    }
}
