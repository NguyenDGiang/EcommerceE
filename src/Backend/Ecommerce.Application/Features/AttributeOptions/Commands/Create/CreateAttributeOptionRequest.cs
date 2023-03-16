using static Ecommerce.Application.Common.Cqrs.CqrsResult;

namespace Ecommerce.Application.Features.AttributeOptions.Commands.Create
{
    public class CreateAttributeOptionRequest : ICommand
    {
        public string Name { get;set; }
    }
}
