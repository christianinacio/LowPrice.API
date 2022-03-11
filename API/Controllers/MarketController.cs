using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LowPrice.API.Application.Market.Commands;
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
        [HttpPost("/api/market")]
        public Task<string> AddMarket([FromBody] AddMarketCommand request)
        {
            return _mediator.Send(request);
        }
        //TODO: agregar a la tabla stock la cantidad del nuevo producto
        [HttpPost("/api/market/{id}/product")]
        public async Task<Product> AddProductToMarket(int id, [FromBody] AddProductToMarketCommand request)
        {
            request.IdMarket = id;
            return await _mediator.Send(request);
        }
        //TODO: sacar cierta cantidad de un producto
        [HttpPut("/api/market/{id}/product")]
        public async Task<IEnumerable<Product>> SellProduct(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}