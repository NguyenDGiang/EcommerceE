using Ecommerce.Domain.Entities;

namespace Ecommerce.Infrastructure.Repositories.ProductVariants
{
    public interface IProductVariantRepository : IRepository<ProductVariant, Guid>
    {
    }
}
