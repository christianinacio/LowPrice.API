using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Market.Commands
{
    public class AddProductToMarketCommandHandler : IRequestHandler<AddProductToMarketCommand, Product>
    {
        public Task<Product> Handle(AddProductToMarketCommand request, CancellationToken cancellationToken)
        {
            //TODO: validar si el idProduct existe

            //TODO: agregar a la tabla stock la cantidad de productos si no existe crear crear la nueva fila
            throw new System.NotImplementedException();
        }
    }
}