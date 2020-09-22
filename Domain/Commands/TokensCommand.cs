using MediatR;

namespace LowPrice.API.Domain.Commands
{
    public class TokensCommand : IRequest<string>
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}