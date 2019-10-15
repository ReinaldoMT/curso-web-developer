using System;

namespace Api.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
