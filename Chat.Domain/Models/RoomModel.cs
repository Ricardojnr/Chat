using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Domain.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserModel User { get; set; }

        public ICollection<MessageModel> Messages { get; set; }

    }
}
