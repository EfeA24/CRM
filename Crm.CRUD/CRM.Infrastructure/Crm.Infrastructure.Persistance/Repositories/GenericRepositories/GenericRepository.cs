using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.SystemEntities;
using Crm.Infrastructure.Persistance.DataContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crm.Infrastructure.Persistance.Repositories.GenericRepositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public virtual async Task AddAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            await _context.Set<T>().AddAsync(entity);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>()
                .Where(x => !(x as BaseEntity).IsDeleted)
                .ToListAsync();
        }


        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual void Remove(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (entity is BaseEntity baseEntity)
            {
                baseEntity.IsDeleted = true;
                baseEntity.DeletedAt = DateTime.UtcNow;
                _context.Set<T>().Update(entity);
            }
            else
            {
                _context.Set<T>().Remove(entity);
            }
        }


        public virtual void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            _context.Set<T>().Update(entity);
        }
    }
}
