using Ecommerce.Infrastructure.SeedWorks;
using MediatR;
using static Ecommerce.Application.Common.Cqrs.CqrsResult;

namespace Ecommerce.Application.Features.Products.Commands.Create
{
    public class CreateProductRequest : ICommand
    {
        public string Name { get; set; }
    }
}
