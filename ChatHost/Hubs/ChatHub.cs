namespace ChatHost.Hubs;
using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    public async Task SendMessage(ChatMessage message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}

public record ChatMessage(string User, string Message);