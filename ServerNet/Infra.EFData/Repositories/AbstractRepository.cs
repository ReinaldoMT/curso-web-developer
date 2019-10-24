using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.EFData.Repositories
{
    public class AbstractRepository<TEntity> : IAbstractRepository<TEntity> where TEntity : AbstractEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public AbstractRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Delete(Guid id)
        {
            var entity = GetById(id);
            entity.IsDeleted = true;
            _dbSet.Update(entity);
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return _dbSet.Where(x => !x.IsDeleted);
        }

        public TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Set(TEntity entity)
        {
            if (_context.Customers.Any(x => x.Id == entity.Id))
            {
                _dbSet.Update(entity);
            }
            else
            {
                _dbSet.Add(entity);
            }
            _context.SaveChanges();
        }
    }
}
