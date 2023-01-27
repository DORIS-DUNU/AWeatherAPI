using AWeatherAPI.Interface;
using AWeatherAPI.RestEaseInterface;
using RestEase;

namespace AWeatherAPI.Implementation
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherApi _weatherService;
        public WeatherService()
        {
            _weatherService = RestClient.For<IWeatherApi>("https://open-weather13.p.rapidapi.com/");
        }
        public async Task<string> GetCurrentWeather(string city)
        {
            var weather = string.Empty;
            try
            {
                weather = await _weatherService.GetCurrentWeather(city);
            }
            catch (ApiException ex)
            {

                throw ex;
            }
            return weather;
        }

        public async Task<string> GetCurrentWeather(string lat, string lon)
        {
            var weather = string.Empty;
            try
            {
                weather = await _weatherService.GetCurrentWeather(lat, lon);
            }
            catch (ApiException ex)
            {

                throw ex;
            }
            return weather;
        }

        public async Task<string> GetFiveDayWeatherForcast(string lat, string lon)
        {
            var weather = string.Empty;
            try
            {
                weather = await _weatherService.GetCurrentWeather(lat, lon);
            }
            catch (ApiException ex)
            {

                throw ex;
            }
            return weather;
        }
    }
}
