using Ecommerce.Application.Features.AttributeValues.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeValueController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpPost]
        public async Task<IActionResult> Post(CreateAttributeValueRequest createAttributeValueRequest)
        {
            return Ok(await Mediator.Send(createAttributeValueRequest));
        }
        //[HttpGet("get-all")]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await Mediator.Send(new GetAttributeOptions()));
        //}
    }
}
