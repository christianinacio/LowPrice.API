using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Market.Commands
{
    public class AddProductToMarketCommand : IRequest<Product>
    {
        public int IdProduct { get; set; }
        public int IdMarket { get; set; }
        public int amount { get; set; }
    }
}