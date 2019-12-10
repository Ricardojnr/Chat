using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Api.Models.ViewModel
{

    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Avatar { get; set; }
        public string CurrentRoom { get; set; }

        public string Token { get; set; }
    }


}
