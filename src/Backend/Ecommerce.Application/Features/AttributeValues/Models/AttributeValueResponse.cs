using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.AttributeValues.Models
{
    public class AttributeValueResponse : EntityBase<Guid>
    {
        public string Value { get; set; }
    }
}
