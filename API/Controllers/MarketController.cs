using System.Collections.Generic;
using System.Threading.Tasks;
using LowPrice.API.Application.Market.Queries;
using LowPrice.API.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LowPrice.API.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarketController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MarketController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("/api/market/{id}/products")]
        public async Task<IEnumerable<Product>> GetProducts(int id)
        {
            var query = new GetAllProductsByMarketQuery
            {
                Id = id
            };
            return await _mediator.Send(query);
        }
    }
}