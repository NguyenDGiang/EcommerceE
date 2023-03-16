using Ecommerce.Infrastructure.SeedWorks;
using MediatR;

namespace Ecommerce.Application.Features.Products.Commands.Create
{
    public class UpdateProductRequest : IRequest<ApiResult>
    {
        public string Name { get; set; }
    }
}
