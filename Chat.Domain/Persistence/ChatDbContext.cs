using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Domain.Persistence
{
    public class ChatDbContext : DbContext
    {
        public DbSet<MessageModel> Messages { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public ChatDbContext(DbContextOptions<ChatDbContext> options)
            : base(options)
        {
        }

    }
}
