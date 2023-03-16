using Ecommerce.Infrastructure.Repositories.AttributeOptions;
using Ecommerce.Infrastructure.Repositories.AttributeValues;
using Ecommerce.Infrastructure.Repositories.Categories;
using Ecommerce.Infrastructure.Repositories.Products;
using Ecommerce.Infrastructure.Repositories.ProductVariants;

namespace Ecommerce.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        public IProductRepository ProductRepository { get; }
        public IProductVariantRepository ProductVariantRepository { get; }
        public IAttributeOptionRepository AttributeOptionRepository { get; }
        public IAttributeValueRepository AttributeValueRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
    }
}
