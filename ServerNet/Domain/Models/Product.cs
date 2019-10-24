using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Product : AbstractEntity
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public double Price { get; set; }
    }
}
