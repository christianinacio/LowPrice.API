using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Data;
using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Queries
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
    {
        private readonly IProductRepo _repository;

        public GetProductQueryHandler(IProductRepo repository)
        {
            this._repository = repository;
        }

        public Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = _repository.GetProductById(request.Id);
            return Task.FromResult(product);
        }
    }
}