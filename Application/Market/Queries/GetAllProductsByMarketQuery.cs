using System.Collections.Generic;
using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Market.Queries
{
    public class GetAllProductsByMarketQuery : IRequest<IEnumerable<Product>>
    {
        public int Id { get; set; }
    }
}