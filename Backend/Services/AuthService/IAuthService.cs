using Backend.DTOs;

namespace Backend.Services.AuthService
{
    public interface IAuthService
    {
       Task<ResponseDto<object>> Login(LoginDto data);
    }
}
