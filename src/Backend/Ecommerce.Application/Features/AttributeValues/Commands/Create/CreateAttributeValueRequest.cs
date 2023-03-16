using static Ecommerce.Application.Common.Cqrs.CqrsResult;

namespace Ecommerce.Application.Features.AttributeValues.Commands.Create
{
    public class CreateAttributeValueRequest : ICommand
    {
        public string Value { get; set; }
        public Guid AttributeOptionId { get; set; }
    }
}
