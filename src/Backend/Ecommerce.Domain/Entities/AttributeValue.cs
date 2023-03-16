using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities
{
    [Table("AttributeValue")]
    public class AttributeValue : EntityBase<Guid>
    {
        public string value { get; set; }
        public ICollection<ProductVariant>? ProductVariant { get; set; }
        [ForeignKey("AttributeOption")]
        public Guid AttributeOptionId { get; set; }
        public AttributeOption AttributeOption { get; set; }
    }
}
