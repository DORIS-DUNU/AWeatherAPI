using AWeatherAPI.DTO;

namespace AWeatherAPI.Interface
{
    public interface IAuthService
    {
        public Task<object> Login(LoginDTO model);
        public Task<object> Register(RegisterDTO user);
    }
}
