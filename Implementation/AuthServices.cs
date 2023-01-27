using AWeatherAPI.DTO;
using AWeatherAPI.Interface;

namespace AWeatherAPI.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<object> Login(LoginDTO model)
        {
            var response = await _authRepository.Login(model);
            return response;
        }


        public async Task<object> Register(RegisterDTO user)
        {
            var response = await _authRepository.Register(user);
            return response;
        }


    }
}
