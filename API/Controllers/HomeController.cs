using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LowPrice.API.API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController
    {
        [HttpGet]
        public async Task<string> Welcome()
        {
            return "Welcome to LowPrice API";
        }
    }
}