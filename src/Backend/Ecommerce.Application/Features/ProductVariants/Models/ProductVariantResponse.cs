using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.ProductVariants.Models
{
    public class ProductVariantResponse : EntityBase<Guid>
    {
        public string Sku { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
