using Chat.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Chat.Infrastructure.Repository
{
    public interface IUserRepository
    {
        Task<UserModel> GetUser(Guid id);

    }
}