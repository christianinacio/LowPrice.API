using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LowPrice.API.API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController
    {
        [HttpGet]
        public Task<string> Welcome()
        {
            return Task.FromResult("Welcome to LowPrice API");
        }
    }
}