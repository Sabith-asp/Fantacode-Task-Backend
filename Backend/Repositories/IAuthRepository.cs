using Backend.Models;

namespace Backend.Repositories
{
    public interface IAuthRepository
    {
        Task<User> GetUserByUserName(string userName);
    }
}
