using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Data;
using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
        
    }

    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepo _repository;

        public GetAllProductsHandler(IProductRepo repository)
        {
            this._repository = repository;
        }

        public Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _repository.GetProducts();
            return Task.FromResult(products);
        }
    }
}