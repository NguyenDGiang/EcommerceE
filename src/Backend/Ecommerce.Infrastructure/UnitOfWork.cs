using Ecommerce.Infrastructure.Persistence;
using Ecommerce.Infrastructure.Repositories.AttributeOptions;
using Ecommerce.Infrastructure.Repositories.AttributeValues;
using Ecommerce.Infrastructure.Repositories.Categories;
using Ecommerce.Infrastructure.Repositories.Products;
using Ecommerce.Infrastructure.Repositories.ProductVariants;

namespace Ecommerce.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IProductRepository _productRepository;
        private IProductVariantRepository _productVariantRepository;
        private IAttributeOptionRepository _attributeOptionRepository;
        private IAttributeValueRepository _attributeValueRepository;
        private ICategoryRepository _categoryRepository;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IProductRepository ProductRepository => _productRepository ??= new ProductRepository(_context);

        public IAttributeOptionRepository AttributeOptionRepository => _attributeOptionRepository ??= new AttributeOptionRepository(_context);

        public IAttributeValueRepository AttributeValueRepository => _attributeValueRepository ??= new AttributeValueRepository(_context);

        public IProductVariantRepository ProductVariantRepository => _productVariantRepository ??= new ProductVariantRepository(_context);

        public ICategoryRepository CategoryRepository => _categoryRepository ??= new CategoryRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
