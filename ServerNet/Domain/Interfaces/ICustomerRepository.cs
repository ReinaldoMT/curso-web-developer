using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Get();
        Customer GetById(Guid id);
        void Set(Customer customer);
        void Delete(Guid id);
    }
}
