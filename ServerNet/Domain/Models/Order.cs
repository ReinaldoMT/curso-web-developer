using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Order : AbstractEntity, IBaseEntity
    {
        public int Number { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public double Total { get; set; }

        public virtual IEnumerable<OrderItem> Items { get; set; }
    }
}
