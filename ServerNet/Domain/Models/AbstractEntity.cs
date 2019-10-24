using Domain.Interfaces;
using System;

namespace Domain.Models
{
    public abstract class AbstractEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
