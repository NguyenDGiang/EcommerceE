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

namespace Ecommerce.Application.Features.Categories.Commands
{
    public class Handler : BaseHandler, IRequestHandler<CreateCategoryRequest, IResult>
    {
        public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IResult> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.CategoryRepository.Add(request.MapTo<Category>());
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Results.Ok(new ApiResult(true, 200, null)) ;
        }
    }
}
