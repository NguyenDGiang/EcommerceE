using AutoMapper;
using Ecommerce.Application.Features.AttributeOptions.Commands.Create;
using Ecommerce.Application.Features.AttributeValues.Commands.Create;
using Ecommerce.Application.Features.AttributeValues.Models;
using Ecommerce.Application.Features.Categories.Commands;
using Ecommerce.Application.Features.Categories.Models;
using Ecommerce.Application.Features.Products.Commands.Create;
using Ecommerce.Application.Features.ProductVariants.Commands.Create;
using Ecommerce.Application.Features.ProductVariants.Models;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Common.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<User, UserReponse>();
            CreateMap<UpdateProductRequest, Product>();
            CreateMap<CreateProductRequest, Product>();
            CreateMap<CreateAttributeOptionRequest, AttributeOption>();
            CreateMap<CreateAttributeValueRequest, AttributeValue>();
            CreateMap<CreateProductVariantRequest, ProductVariant>();
            CreateMap<ProductVariant, ProductResponse>();
            CreateMap<ProductVariant, ProductVariantResponse>();
            CreateMap<AttributeValue, AttributeValueResponse>();
            CreateMap<AttributeValueResponse, AttributeValue>();
            //CreateMap<ColorCreateRequest, Color>();
            //CreateMap<Color, ColorReponse>();
            ////CreateMap<CapacityCreateRequest, Capacity>();
            //CreateMap<Capacity, CapacityReponse>();
            CreateMap<CreateCategoryRequest, Category>();
            CreateMap<Category, CategoryResponse>();
            //CreateMap<InsertUploadFileToProductRequest, UploadFile>();
        }
    }
}
