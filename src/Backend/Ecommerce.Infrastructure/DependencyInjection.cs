using Ecommerce.Infrastructure.Repositories;
using Ecommerce.Infrastructure.Repositories.AttributeOptions;
using Ecommerce.Infrastructure.Repositories.AttributeValues;
using Ecommerce.Infrastructure.Repositories.Categories;
using Ecommerce.Infrastructure.Repositories.Products;
using Ecommerce.Infrastructure.Repositories.ProductVariants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration["Redis:Configuration"];
            });
            //DI Container
            services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddTransient(typeof(IRepository<,>),typeof(Repository<,>));
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IAttributeOptionRepository, AttributeOptionRepository>();
            services.AddTransient<IAttributeValueRepository, AttributeValueRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductVariantRepository, ProductVariantRepository>();
            return services;
        }
    }
}
