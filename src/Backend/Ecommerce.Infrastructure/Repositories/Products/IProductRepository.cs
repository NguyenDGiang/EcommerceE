using Ecommerce.Domain.Entities;

namespace Ecommerce.Infrastructure.Repositories.Products
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}
