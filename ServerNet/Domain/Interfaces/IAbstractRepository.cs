using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IAbstractRepository<T>
    {
        IEnumerable<T> Get();
        T GetById(Guid id);
        void Set(T entity);
        void Delete(Guid id);
    }
}
