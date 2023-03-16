using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Persistence;

namespace Ecommerce.Infrastructure.Repositories.AttributeValues
{
    public class AttributeValueRepository : Repository<AttributeValue, Guid>, IAttributeValueRepository
    {
        public AttributeValueRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
