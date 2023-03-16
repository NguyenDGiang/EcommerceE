using Ecommerce.Application.Features.AttributeValues.Models;
using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.AttributeOptions.Models
{
    public class AttributeOptionResponse : EntityBase<Guid>
    {
        public string Name { get; set; }
        public List<AttributeValueResponse> AttributeValues { get; set; }
    }
}
