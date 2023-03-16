using Ecommerce.Application.Features.Products.Models;
using Ecommerce.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Application.Features.Products.Queries.GetAll
{
    public class Handler : BaseHandler, IRequestHandler<GetProductsQuery, IResult>
    {
        public Handler(IUnitOfWork unitOfWork)
            : base(unitOfWork) { }

        public async Task<IResult> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            IQueryable<ProductReponse> products = _unitOfWork.ProductRepository.
                FindAll().Select(x => new ProductReponse()
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreatedDate = x.CreatedDate,
                    IsDelete = x.IsDelete,
                    LastModifiedDate = x.LastModifiedDate
                });
            return Results.Ok(await products.ToListAsync());
        }
    }
}
