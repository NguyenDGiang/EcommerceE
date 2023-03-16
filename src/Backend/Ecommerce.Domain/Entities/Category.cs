using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities
{
    [Table("Category")]
    public class Category : EntityBase<Guid>
    {
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
