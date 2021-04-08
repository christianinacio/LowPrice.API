using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LowPrice.API.Data;
using LowPrice.API.Domain.Models;
using LowPrice.API.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LowPrice.API.Application.Commands;

namespace LowPrice.API.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            var query = new GetAllProductsQuery();
            return await _mediator.Send(query);
        }

        [HttpGet("/api/products/{id}")]
        public async Task<Product> GetProducts(int id)
        {
            var query = new GetProductQuery
            {
                Id = id
            };
            return await _mediator.Send(query);
        }
        
        [HttpPost("/api/products")]
        public Task<string> InsertProducts([FromBody]CreateProductCommand request)
        {
            return _mediator.Send(request);
        }
    }
}