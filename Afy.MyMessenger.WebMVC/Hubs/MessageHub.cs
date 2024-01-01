using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace Afy.MyMessenger.WebMVC.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendName(string message)
        {
            await Clients.All.SendAsync("ReceiveName", message);
        }

        public async Task JoinGroupChat(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task SendGroupMessage(string groupName, string message)
        {
            await Clients.Group(groupName).SendAsync("ReceiveGroupMessage", message);
        }
    }
}
