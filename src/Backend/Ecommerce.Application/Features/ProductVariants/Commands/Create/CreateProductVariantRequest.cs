using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.Common.Cqrs.CqrsResult;

namespace Ecommerce.Application.Features.ProductVariants.Commands.Create
{
    public class CreateProductVariantRequest : ICommand
    {
        public string Sku { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid ProductId { get; set; }
        public Guid? AttributeOptionId { get; set; }
        public Guid? AttributeValueId { get; set; }
    }
}
