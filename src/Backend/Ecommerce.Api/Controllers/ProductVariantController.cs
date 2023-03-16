using Ecommerce.Application.Features.ProductVariants.Commands.Create;
using Ecommerce.Application.Features.ProductVariants.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariantController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductVariantRequest createProductVariantRequest)
        {
            return Ok(await Mediator.Send(createProductVariantRequest));
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetProducts()));
        }
    }
}
