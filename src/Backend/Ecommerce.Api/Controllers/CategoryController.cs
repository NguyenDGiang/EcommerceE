using Ecommerce.Application.Features.Categories.Commands;
using Ecommerce.Application.Features.Categories.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpPost]
        public async Task<IActionResult> Post(CreateCategoryRequest createCategoryRequest)
        {
            return Ok(await Mediator.Send(createCategoryRequest));
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetCategories()));
        }
    }
}
