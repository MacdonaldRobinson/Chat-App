using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string message, DateTime dateTime)
        {
          await Clients.All.SendAsync("RecieveMessage", name, message, dateTime);
        }
    }
}