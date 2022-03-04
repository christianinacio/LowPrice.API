using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace LowPrice.API.Application.Hubs
{
    public class LowPriceHub : Hub
    {
        public static ConcurrentDictionary<string, UserDetail> UsersConnected = new ConcurrentDictionary<string, UserDetail>();
        public override async Task OnConnectedAsync()
        {
            //UsersConnected.TryAdd(Context.ConnectionId, new UserDetail{ Name= "test"});
            await Clients.Caller.SendAsync("Conexión exitosa", Context.User.Identity.Name, "joined");
            //await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception exception)
    {
        UserDetail user;

        UsersConnected.TryRemove(Context.ConnectionId, out user);

        await base.OnDisconnectedAsync(exception);
    }
        public async Task Send(string name, string message)
        {
            Console.WriteLine(message);
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }
    }
}