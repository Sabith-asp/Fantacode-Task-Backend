using Backend.Models;

namespace Backend.Services.JwtService
{
    public interface IJwtService
    {
        Task<string> GenerateToken(User user);
    }
}
