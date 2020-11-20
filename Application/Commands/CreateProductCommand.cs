using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Commands
{
    public class CreateProductCommand : IRequest<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public Type Type { get; set; }
        public double Price { get; set; }
        public string Update{ get; set; }
    }
}