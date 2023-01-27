using RestEase;

namespace AWeatherAPI.Interface
{
    public interface IWeatherService
    {
        Task<string> GetCurrentWeather(string city);
        Task<string> GetCurrentWeather(string lat, string lon);
        Task<string> GetFiveDayWeatherForcast(string lat, string lon);
    }
}
