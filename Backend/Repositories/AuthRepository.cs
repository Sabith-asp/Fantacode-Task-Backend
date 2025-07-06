using Backend.Models;

namespace Backend.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private static readonly List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Xyron Velt", UserName = "xyronv99", Password = "xP3!t9#lm" },
            new User { Id = 2, Name = "Lara Mints", UserName = "mint_lara", Password = "Lm8*psA1" },
            new User { Id = 3, Name = "Zed Rake", UserName = "zedrake", Password = "Zed@2025" },
            new User { Id = 4, Name = "Noah Greft", UserName = "n_greft", Password = "123Noah!" },
            new User { Id = 5, Name = "Anvi Deron", UserName = "deron.anv", Password = "aD#56er!" },
            new User { Id = 5, Name = "Ameen", UserName = "ameen123", Password = "Ameen@123" }

        };

        public async Task<User> GetUserByUserName(string userName)
        {
            var user = users.FirstOrDefault(u => u.UserName == userName);
            return await Task.FromResult(user);
        }
    }
}
