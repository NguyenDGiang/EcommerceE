using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Persistence;

namespace Ecommerce.Infrastructure.Repositories.AttributeOptions
{
    public class AttributeOptionRepository : Repository<AttributeOption, Guid>, IAttributeOptionRepository
    {
        public AttributeOptionRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
