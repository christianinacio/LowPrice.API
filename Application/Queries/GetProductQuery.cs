using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LowPrice.API.Data;
using LowPrice.API.Domain.Models;
using MediatR;

namespace LowPrice.API.Application.Queries
{
    public class GetProductQuery : IRequest<Product>
    {
        public string Id { get; set; }
    }
}