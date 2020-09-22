using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Data;
using MediatR;

namespace LowPrice.API.Domain.Commands
{
    public class TokensCommandHandler : IRequestHandler<TokensCommand, string>
    {
        private readonly IProductRepo _repository;

        public Task<string> Handle(TokensCommand request, CancellationToken cancellationToken)
        {
            //Consultar a la DB si existe un user si es asi genera el token
            throw new System.NotImplementedException();
        }
    }
}