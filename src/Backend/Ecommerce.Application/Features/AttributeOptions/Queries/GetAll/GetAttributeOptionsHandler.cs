using Ecommerce.Application.Features.AttributeOptions.Models;
using Ecommerce.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Application.Features.AttributeOptions.Queries.GetAll
{
    public class Handler : BaseHandler, IRequestHandler<GetAttributeOptions, IResult>
    {
        public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IResult> Handle(GetAttributeOptions request, CancellationToken cancellationToken)
        {
            List<AttributeOptionResponse> attributeOptions = await _unitOfWork.AttributeOptionRepository
                .FindAll()
                .Select(x => new AttributeOptionResponse()
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDelete = x.IsDelete,
                    CreatedDate = x.CreatedDate,
                    LastModifiedDate = x.LastModifiedDate
                }).ToListAsync();
            return Results.Ok(attributeOptions);
        }
    }
}
