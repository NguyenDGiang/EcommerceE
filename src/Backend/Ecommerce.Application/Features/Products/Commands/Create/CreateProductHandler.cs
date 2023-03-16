using Ecommerce.Application.Common.MappingProfiles;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure;
using Ecommerce.Infrastructure.SeedWorks;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Application.Features.Products.Commands.Create
{
    public class Handler : BaseHandler, IRequestHandler<CreateProductRequest, IResult>
    {
        public Handler(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public async Task<IResult> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {

            await _unitOfWork.ProductRepository.Add(request.MapTo<Product>());

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Results.Ok(new ApiResult(true, 200, null));
        }
    }
}
