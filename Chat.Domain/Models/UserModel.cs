using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chat.Domain.Models
{
    public class UserModel
    {
        [Key]
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<RoomModel> Rooms { get; set; }

        public virtual ICollection<MessageModel> Messages { get; set; }
    }
}