using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public class CustomerRepository
    {
        private readonly List<Customer> _data = new List<Customer>();

        public Customer GetById (Guid id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }

        public Customer Add (Customer customer)
        {
            _data.Add(customer);
            return customer;
        }

        public void Update (Guid id, Customer customer)
        {
            var data = GetById(id);
            if (customer == null)
                return;

            data.IsActive = customer.IsActive;
            data.Name = customer.Name;
        }

        public IEnumerable<Customer> Get ()
        {
            return _data;
        }

        public IEnumerable<Customer> GetActives ()
        {
            return _data.Where(x => x.IsActive);
        }

        public void Delete (Guid id)
        {
            var customer = GetById(id);
            _data.Remove(customer);
        }
    }
}
