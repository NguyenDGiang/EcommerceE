using Ecommerce.Application.Features.AttributeOptions.Commands.Create;
using Ecommerce.Application.Features.AttributeOptions.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeOptionController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpPost]
        public async Task<IActionResult> Post(CreateAttributeOptionRequest createAttributeOptionRequest)
        {
            return Ok(await Mediator.Send(createAttributeOptionRequest));
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetAttributeOptions()));
        }
    }
}
