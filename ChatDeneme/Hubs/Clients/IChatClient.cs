using System.Threading.Tasks;
using ChatDeneme.Models;

namespace ChatDeneme.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}