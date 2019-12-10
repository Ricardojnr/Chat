using Chat.Api.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Api.Authentication
{
    public interface IUserService
    {
        UserViewModel Authenticate(string username, string password);
        IEnumerable<UserViewModel> GetAll();
    }
}
