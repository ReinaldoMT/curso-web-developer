using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class OrderItem : AbstractEntity
    {
        public DateTime CreatedAt { get; set; }

        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Total { get; set; }
    }
}
