using System.Net.WebSockets;
using System.Threading.Tasks;
using ChatDeneme.Hubs.Clients;
using ChatDeneme.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatDeneme.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
    }
}