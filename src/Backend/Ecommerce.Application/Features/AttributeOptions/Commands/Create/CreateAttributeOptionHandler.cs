using Ecommerce.Application.Common.MappingProfiles;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure;
using Ecommerce.Infrastructure.SeedWorks;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Application.Features.AttributeOptions.Commands.Create
{
    public class Handler : BaseHandler, IRequestHandler<CreateAttributeOptionRequest, IResult>
    {

        public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IResult> Handle(CreateAttributeOptionRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.AttributeOptionRepository.Add(request.MapTo<AttributeOption>());
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Results.Ok(new ApiResult(true, 200, null));
        }
    }
}
