using Ecommerce.Application.Common.MappingProfiles;
using Ecommerce.Application.Features.AttributeOptions.Models;
using Ecommerce.Application.Features.AttributeValues.Models;
using Ecommerce.Application.Features.Categories.Models;
using Ecommerce.Application.Features.ProductVariants.Models;
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

namespace Ecommerce.Application.Features.ProductVariants.Queries.GetAll
{
    public class Handler : BaseHandler, IRequestHandler<GetProducts, IResult>
    {
        public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IResult> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            var products = _unitOfWork.ProductRepository.FindAll();
            var attributeOptions = _unitOfWork.AttributeOptionRepository.FindAll();
            var attributeValues = _unitOfWork.AttributeValueRepository.FindAll();
            var productVariants = _unitOfWork.ProductVariantRepository.FindAll();
            var categories = _unitOfWork.CategoryRepository.FindAll();
            var x = from productVariant in productVariants
                    join product in products
                    on productVariant.ProductId equals product.Id
                    select new {product, productVariant };

            var y = _unitOfWork.ProductRepository.FindAll()
                .Select(x => new ProductResponse()
                {
                    ProductVariants = x.ProductVariant.Select(x => new ProductVariantResponse()
                    {
                        
                    }).MapListTo<ProductVariantResponse>()
                });

var productsResult = from productVariant in productVariants
                                 join attributeOption in attributeOptions
                                 on productVariant.AttributeOptionId equals attributeOption.Id
                                 into attributeOptionLeft
                                 from attributeOption in attributeOptionLeft.DefaultIfEmpty()
                                 join attributeValue in attributeValues
                                 on productVariant.AttributeValueId equals attributeValue.Id
                                 into attributeValueLeft
                                 from attributeValue in attributeValueLeft.DefaultIfEmpty()
                                 join product in products
                                 on productVariant.ProductId equals product.Id
                                 into productLeft
                                 from product in productLeft.DefaultIfEmpty()
                                 select new ProductResponse
                                 {
                                     Id = product.Id,
                                     Name = product.Name,
                                     IsDelete = product.IsDelete,
                                     CreatedDate = product.CreatedDate,
                                     LastModifiedDate = product.LastModifiedDate,
                                     AttributeOptions = product.AttributeOption
                                     .Select(x => new AttributeOptionResponse()
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         IsDelete = x.IsDelete,
                                         CreatedDate = x.CreatedDate,
                                         LastModifiedDate = x.LastModifiedDate,
                                         AttributeValues = x.AttributeValue.Where(x => x.Id.Equals(productVariant.AttributeValueId)).MapListTo<AttributeValueResponse>()
                                     }).ToList(),

                                     ProductVariants = product.ProductVariant.MapListTo<ProductVariantResponse>()

                                 };
            
            return Results.Ok(await productsResult.ToListAsync());
        }
    }
}
