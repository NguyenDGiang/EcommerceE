using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities
{
    [Table("AttributeOption")]
    public class AttributeOption : EntityBase<Guid>
    {
        public string Name { get; set; }
        public ICollection<AttributeValue> AttributeValue { get; set; }
        [ForeignKey("Product")]
        public Guid? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
