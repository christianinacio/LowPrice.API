using System.Threading.Tasks;
using LowPrice.API.Domain.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LowPrice.API.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TokenController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult>  Create([FromBody] TokensCommand request){
            return this.Ok(await _mediator.Send(request));
        }
    }
}