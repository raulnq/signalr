using Microsoft.AspNetCore.SignalR;

namespace WebAPI;

public class ChatHub : Hub
{
    public Task SendMessage(string message, string user)
    {
        return Clients.All.SendAsync("ReceiveMessage", message, user);
    }
}