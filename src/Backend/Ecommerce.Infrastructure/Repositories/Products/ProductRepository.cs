using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Persistence;

namespace Ecommerce.Infrastructure.Repositories.Products
{
    public class ProductRepository : Repository<Product, Guid>, IProductRepository
    {
        public ProductRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
