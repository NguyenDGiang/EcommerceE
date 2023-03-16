using Ecommerce.Domain.Common;
using Ecommerce.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ecommerce.Infrastructure.Repositories
{
    public class Repository<T,K> : IRepository<T,K> where T : EntityBase<K>
    {
        private readonly DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<T> FindById(K id, params Expression<Func<T, object>>[] includeProperties)
        {
            return await FindAll(includeProperties).SingleOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<T> FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            return await FindAll(includeProperties).SingleOrDefaultAsync(predicate);
        }

        public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (Expression<Func<T, object>>? item in includeProperties)
                {
                    items = items.Include(item);
                }
            }

            return items;
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (Expression<Func<T, object>>? item in includeProperties)
                {
                    items = items.Include(item);
                }
            }

            return items.Where(predicate);
        }

        public async Task Add(T entity)
        {
            try
            {
                _ = await _context.Set<T>().AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Update(T entity)
        {
            T? dbEntity = await _context.Set<T>().AsNoTracking().SingleAsync(p => p.Id.Equals(entity.Id));
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T>? databaseEntry = _context.Entry(dbEntity);
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T>? inputEntry = _context.Entry(entity);

            //no items mentioned, so find out the updated entries
            IEnumerable<string> dateProperties = typeof(IDateTracking).GetProperties().Select(x => x.Name);

            IEnumerable<Microsoft.EntityFrameworkCore.Metadata.IProperty>? allProperties = databaseEntry.Metadata.GetProperties()
                .Where(x => !dateProperties.Contains(x.Name));

            foreach (Microsoft.EntityFrameworkCore.Metadata.IProperty? property in allProperties)
            {
                object? proposedValue = inputEntry.Property(property.Name).CurrentValue;
                object? originalValue = databaseEntry.Property(property.Name).OriginalValue;

                if (proposedValue != null && !proposedValue.Equals(originalValue))
                {
                    databaseEntry.Property(property.Name).IsModified = true;
                    databaseEntry.Property(property.Name).CurrentValue = proposedValue;
                }
            }

            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T>? result = _context.Set<T>().Update(dbEntity);
            return result.Entity;
        }

        public void Remove(T entity)
        {
            _ = _context.Set<T>().Remove(entity);
        }

        public async void Remove(K id)
        {
            Remove(await FindById(id));
        }

        public void RemoveMultiple(List<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
