using Chat.Api.Models.ViewModel;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Api.Hubs
{
    public static class ChatHubManager
    {
        public static Task NewMessageAsync(this IClientProxy clientProxy, string message)
        {
            return  clientProxy.SendAsync("NewMessage", message);
        }
    }
}
