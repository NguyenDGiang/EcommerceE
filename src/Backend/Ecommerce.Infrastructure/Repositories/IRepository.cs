using System.Linq.Expressions;

namespace Ecommerce.Infrastructure.Repositories
{
    public interface IRepository<T,K>
    {
        Task<T> FindById(K id, params Expression<Func<T, object>>[] includeProperties);

        Task<T> FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties);

        Task Add(T entity);

        Task<T> Update(T entity);

        void Remove(T entity);

        void Remove(K id);

        void RemoveMultiple(List<T> entities);
    }
}
