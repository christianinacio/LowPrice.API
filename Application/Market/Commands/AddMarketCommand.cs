using MediatR;

namespace LowPrice.API.Application.Market.Commands
{
    public class AddMarketCommand : IRequest<string>
    {
        public string Address { get; set; }
    }
}