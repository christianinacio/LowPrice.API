using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Data;
using MediatR;

namespace LowPrice.API.Application.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepo _repository;

        public DeleteProductCommandHandler(IProductRepo repository)
        {
            this._repository = repository;
        }
        public Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.DeleteProduct(request.Id));
        }
    }
}