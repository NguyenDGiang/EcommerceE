using Ecommerce.Application.Common.MappingProfiles;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure;
using Ecommerce.Infrastructure.SeedWorks;
using MediatR;

namespace Ecommerce.Application.Features.Products.Commands.Create
{
    public class UpdateProductHandler : BaseHandler, IRequestHandler<UpdateProductRequest, ApiResult>
    {
        public UpdateProductHandler(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public async Task<ApiResult> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {

            await _unitOfWork.ProductRepository.Update(request.MapTo<Product>());

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new ApiResult(true, 200, null);
        }
    }
}
