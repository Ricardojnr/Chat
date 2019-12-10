using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Domain.Models
{
    public class MessageModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string TimeStamp { get; set; }
        public UserModel FromUser { get; set; }

        public virtual RoomModel ToRoom { get; set; }
    }
}
