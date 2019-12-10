using Chat.Domain.Models;
using Chat.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Infrastructure.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly ChatDbContext _context;

        public UserRepository(ChatDbContext context)
        {
            _context = context;

        }
        public async Task<UserModel> GetUser(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
