using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Data;
using MediatR;

namespace LowPrice.API.Application.Market.Commands
{
    public class AddMarketCommandHandler : IRequestHandler<AddMarketCommand, string>
    {
        private readonly IMarketRepo _repository;

        public AddMarketCommandHandler(IMarketRepo repository)
        {
            this._repository = repository;
        }
        public Task<string> Handle(AddMarketCommand request, CancellationToken cancellationToken)
        {
            var market = new Domain.Models.Market(){
                Address = request.Address
            };
            _repository.AddMarket(market);
            return Task.FromResult("OK");
        }
    }
}