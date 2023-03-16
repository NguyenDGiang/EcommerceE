using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Models
{
    public class CategoryResponse : EntityBase<Guid> 
    { 
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        public List<CategoryResponse>? CategoryChildren { get; set; }
    }
}
