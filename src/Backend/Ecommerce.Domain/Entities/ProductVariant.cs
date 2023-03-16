using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities
{
    [Table("ProductVariant")]
    public class ProductVariant : EntityBase<Guid>
    {
        public string Sku { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("AttributeOption")]
        public Guid? AttributeOptionId { get; set; }
        public AttributeOption? AttributeOption { get; set; }
        [ForeignKey("AttributeValue")]
        public Guid? AttributeValueId { get; set; }
        public AttributeValue? AttributeValue { get; set; }
    }
}
