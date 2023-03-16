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

namespace Ecommerce.Application.Features.AttributeValues.Commands.Create
{
    internal class Handler : BaseHandler, IRequestHandler<CreateAttributeValueRequest, IResult>
    {
        public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IResult> Handle(CreateAttributeValueRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.AttributeValueRepository.Add(request.MapTo<AttributeValue>());
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Results.Ok(new ApiResult(true, 200, null));
        }
    }
}
