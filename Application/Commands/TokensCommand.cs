using MediatR;

namespace LowPrice.API.Application.Commands
{
    public class TokensCommand : IRequest<string>
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}