using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Persistence;

namespace Ecommerce.Infrastructure.Repositories.ProductVariants
{
    public class ProductVariantRepository : Repository<ProductVariant, Guid>, IProductVariantRepository
    {
        public ProductVariantRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
