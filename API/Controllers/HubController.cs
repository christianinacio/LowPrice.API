using LowPrice.API.Application.Hubs;
using Microsoft.AspNetCore.Mvc;

namespace LowPrice.API.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HubController : ControllerBase
    {
        //public IHubContext<HubCommands, IHubCommands> SupervisorHubContext { get; }

        // public HubController(LowPriceHub LowPriceHubContext)
        // {
        //     this.SupervisorHubContext = supervisorHubContext;
        // }
        // [HttpGet]
        // public Task<string> Welcome()
        // {
        //     return Task.FromResult("Welcome to LowPrice API");
        // }
    }
}