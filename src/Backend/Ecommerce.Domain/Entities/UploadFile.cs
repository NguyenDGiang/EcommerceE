using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities
{
    public class UploadFile : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public Product? Product { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
    }
}
