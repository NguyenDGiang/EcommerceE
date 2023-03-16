using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities
{
    public class Product : EntityBase<Guid>
    {
        public string Name { get; set; }
        public Category? Category { get; set; }
        public ICollection<AttributeOption> AttributeOption { get; set; }
        public ICollection<ProductVariant> ProductVariant { get; set; }
        public ICollection<UploadFile> UploadFile { get; set; }

    }
}
