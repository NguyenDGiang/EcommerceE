using Ecommerce.Application.Common.MappingProfiles;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure;
using Ecommerce.Infrastructure.SeedWorks;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.ProductVariants.Commands.Create
{
    public class Handler : BaseHandler, IRequestHandler<CreateProductVariantRequest, IResult>
    {
        public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IResult> Handle(CreateProductVariantRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.ProductVariantRepository.Add(request.MapTo<ProductVariant>());
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Results.Ok(new ApiResult(true, 200, null));
        }
    }
}
