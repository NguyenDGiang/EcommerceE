using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.Common.Cqrs.CqrsResult;

namespace Ecommerce.Application.Features.Categories.Commands
{
    public class CreateCategoryRequest : ICommand
    {
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
    }
}
