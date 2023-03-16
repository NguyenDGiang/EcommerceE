using Ecommerce.Application.Features.AttributeOptions.Models;
using Ecommerce.Application.Features.Categories.Models;
using Ecommerce.Domain.Common;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Features.ProductVariants.Models
{
    public class ProductResponse : EntityBase<Guid>
    {
        public string Name { get; set; }
        public List<AttributeOptionResponse> AttributeOptions { get; set; }
        public List<ProductVariantResponse> ProductVariants { get; set; }
        public CategoryResponse CategoryResponse { get; set; }
        public List<UploadFile> UploadFiles { get; set; }
    }
}
