using Backend.DTOs;
using Backend.Repositories;
using Backend.Services.JwtService;

namespace Backend.Services.AuthService
{
    public class AuthService:IAuthService
    {
        private readonly IAuthRepository authRepo;
        private readonly IJwtService jwtService;

        public AuthService(IAuthRepository _authRepo, IJwtService _jwtService) {
            authRepo = _authRepo;
            jwtService = _jwtService;
        }
        public async Task<ResponseDto<object>> Login(LoginDto data)
        {
            try {
                var user=await authRepo.GetUserByUserName(data.UserName);
                if (user == null || user.Password!=data.Password) {
                    return new ResponseDto<object> { StatusCode = 400,Message="Invalid Credentials" };
                }
                var token = await jwtService.GenerateToken(user);

                return new ResponseDto<object> { StatusCode = 200, Message = "Login successful",Data=new { token=token} };

            }
            catch (Exception ex) {
                return new ResponseDto<object> { StatusCode = 500, Message = "Error in login" };

            }
        }


    }
}
