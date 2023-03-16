using Ecommerce.Application.Common.MappingProfiles;
using Ecommerce.Application.Features.Categories.Models;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Queries.GetAll
{
    public class Handler : BaseHandler, IRequestHandler<GetCategories, IResult>
    {
        public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IResult> Handle(GetCategories request, CancellationToken cancellationToken)
        {
            var categories = _unitOfWork.CategoryRepository
                .FindAll()
                .ToList()
                .MapListTo<CategoryResponse>();
            return Results.Ok(await GetCategoriesReCursive(categories, null));
        }

        public async Task<List<CategoryResponse>> GetCategoriesReCursive(List<CategoryResponse> categories, Guid? Id)
        {
            List<CategoryResponse> result = new List<CategoryResponse>();
            foreach (var item in categories.Where(x => Id == null ? x.ParentId == null : x.ParentId.Equals(Id)))
            {
                CategoryResponse category = new CategoryResponse();
                category.Id = item.Id;
                category.Name = item.Name;
                category.ParentId = item.ParentId;
                category.CategoryChildren = await GetCategoriesReCursive(categories, item.Id);
                result.Add(category);

            }
            return await Task.FromResult(result);
        }
    }
}
