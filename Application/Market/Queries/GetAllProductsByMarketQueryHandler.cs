using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Application.Queries;
using LowPrice.API.Data;
using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Market.Queries
{
    public class GetAllProductsByMarketQueryHandler : IRequestHandler<GetAllProductsByMarketQuery, IEnumerable<Product>>
    {

        public GetAllProductsByMarketQueryHandler()
        {
        }
        public Task<IEnumerable<Product>> Handle(GetAllProductsByMarketQuery request, CancellationToken cancellationToken)
        {
            //TODO: return stock of Market by id
            throw new System.NotImplementedException();
        }
    }
}