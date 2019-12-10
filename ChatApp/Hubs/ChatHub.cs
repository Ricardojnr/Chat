
using Chat.Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.Api.Hubs;

namespace ChatApp.Hubs
{
    [Authorize]


    public class ChatHub : Hub
    {
        private IUserRepository _userRepository;
        private readonly static Dictionary<string, string> _ConnectionsMap = new Dictionary<string, string>();
        public string GetUser => Context.User.Identity.Name;

        public ChatHub(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private string User(string user)
        {
            if (user == "Maria")
                return "John";

            return "Maria";
        }
        public async Task SendPrivateMessage(string toUser, string message)
        {
            var user = User(toUser);
            var userId = _ConnectionsMap[user];

            
            await Clients.Client(userId).NewMessageAsync(message);
            
            await Clients.Caller.NewMessageAsync(message);
        }

        public override async Task OnConnectedAsync()
        {
            _ConnectionsMap.Add(GetUser, Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            _ConnectionsMap.Remove(GetUser);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
