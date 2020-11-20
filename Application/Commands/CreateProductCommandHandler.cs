using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Data;
using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, string>
    {
        private readonly IProductRepo _repository;

        public CreateProductCommandHandler(IProductRepo repository)
        {
            this._repository = repository;
        }
        public Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var mock = new Product();
            var prod = _repository.InsertProduct(mock);
            return Task.FromResult("OK");
        }
    }
}