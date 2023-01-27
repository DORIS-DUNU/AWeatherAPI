using RestEase;

namespace AWeatherAPI.RestEaseInterface
{
    [Header("X-RapidAPI-Key", "f0e773a024msh4f2a4ce93fd48edp14e139jsn8900dae35461")]
    [Header("X-RapidAPI-Host", "open-weather13.p.rapidapi.com")]
    public interface IWeatherApi
    {
        [Get("city/{cityName}")]
        Task<string> GetCurrentWeather([Path] string cityName);

        [Get("city/latlon/{lat}/{lon}")]
        Task<string> GetCurrentWeather([Path]string lat, [Path]string lon);

        [Get("city/{lat}/{lon}")]
        Task<string> GetFiveDayWeatherForcast([Path] string lat, [Path] string lon);
    }
}
