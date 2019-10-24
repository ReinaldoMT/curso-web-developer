using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{

    public class Customer : AbstractEntity, IBaseEntity
    {
        public Guid TenantId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string Telefone { get; set; }
    }
}
