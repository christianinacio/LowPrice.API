using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Commands
{
    public class CreateProductCommand : IRequest<string>
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Type { get; set; }
        public double Price { get; set; }
    }
}