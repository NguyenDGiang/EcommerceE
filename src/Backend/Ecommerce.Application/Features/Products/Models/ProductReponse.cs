using Ecommerce.Domain.Common;
using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Products.Models
{
    public class ProductReponse : EntityBase<Guid>
    {
        public string Name { get; set; }
    }
}
